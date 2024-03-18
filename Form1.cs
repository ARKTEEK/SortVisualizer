using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SortVisualizer {
  public partial class Form1 : Form {
    private readonly Dictionary<string, GraphCard> _charts;
    private readonly Stopwatch _stopWatch = new Stopwatch();
    private bool _isVisualizingEnabled = true;

    private int[] _numbers;
    private int[] _numbersCopy;

    public Form1() {
      InitializeComponent();

      _charts = new Dictionary<string, GraphCard> {
        { "Bubble", graphCard1 },
        { "Selection", graphCard2 },
        { "Insertion", graphCard3 },
        { "Merge", graphCard4 },
        { "Quick", graphCard5 },
        { "Heap", graphCard7 },
        { "Gnome", graphCard8 },
        { "Pancake", graphCard9 }
      };

      _charts["Bubble"].chartLabel.Text = @"Bubble sort";

      _charts["Bubble"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Bubble"]);

        if (_numbers is null) {
          return;
        }

        _numbersCopy = (int[])_numbers.Clone();

        BubbleSort(_numbersCopy);

        UpdateGraph(_charts["Bubble"], _numbersCopy, -1);
      };

      _charts["Selection"].chartLabel.Text = @"Selection sort";

      _charts["Selection"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Selection"]);

        if (_numbers is null) {
          return;
        }

        _numbersCopy = (int[])_numbers.Clone();

        SelectionSort(_numbersCopy);

        UpdateGraph(_charts["Selection"], _numbersCopy, -1);
      };

      _charts["Insertion"].chartLabel.Text = @"Insertion sort";

      _charts["Insertion"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Insertion"]);

        if (_numbers is null) {
          return;
        }

        _numbersCopy = (int[])_numbers.Clone();

        InsertionSort(_numbersCopy);

        UpdateGraph(_charts["Insertion"], _numbersCopy, -1);
      };

      _charts["Merge"].chartLabel.Text = @"Merge sort";

      _charts["Merge"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Merge"]);

        if (_numbers is null) {
          return;
        }

        _numbersCopy = (int[])_numbers.Clone();

        _stopWatch.Reset();
        _stopWatch.Start();

        _numbersCopy = MergeSort(_numbersCopy, 0, _numbersCopy.Length);

        _stopWatch.Stop();

        UpdateGraph(_charts["Merge"], _numbersCopy, -1);
      };

      _charts["Quick"].chartLabel.Text = @"Quick sort";

      _charts["Quick"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Quick"]);

        if (_numbers is null) {
          return;
        }

        _numbersCopy = (int[])_numbers.Clone();

        _stopWatch.Reset();
        _stopWatch.Start();

        QuickSort(_numbersCopy, 0, _numbersCopy.Length - 1);

        _stopWatch.Stop();

        UpdateGraph(_charts["Quick"], _numbersCopy, -1);
      };

      _charts["Heap"].chartLabel.Text = @"Heap sort";

      _charts["Heap"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Heap"]);

        if (_numbers is null) {
          return;
        }

        _numbersCopy = (int[])_numbers.Clone();

        HeapSort(_numbersCopy);

        UpdateGraph(_charts["Heap"], _numbersCopy, -1);
      };

      _charts["Gnome"].chartLabel.Text = @"Gnome sort";

      _charts["Gnome"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Gnome"]);

        if (_numbers is null) {
          return;
        }

        _numbersCopy = (int[])_numbers.Clone();

        GnomeSort(_numbersCopy);

        UpdateGraph(_charts["Gnome"], _numbersCopy, -1);
      };

      _charts["Pancake"].chartLabel.Text = @"Pancake sort";

      _charts["Pancake"].chartButton.Click += delegate {
        UpdateGraphState(_charts["Pancake"]);

        if (_numbers is null) {
          return;
        }


        _numbersCopy = (int[])_numbers.Clone();

        _stopWatch.Reset();
        _stopWatch.Start();

        PancakeSort(_numbersCopy, _numbersCopy.Length);

        _stopWatch.Stop();

        UpdateGraph(_charts["Pancake"], _numbersCopy, -1);
      };
    }

    #region UI handlers

    private void Button1_Click(object sender, EventArgs e) {
      int sizeOfArray = (int)numericUpDown1.Value;

      _numbers = new int[sizeOfArray];

      Random rnd = new Random();

      for (int i = 0; i < sizeOfArray; i++) {
        _numbers[i] = rnd.Next(0, 1000);
      }

      richTextBox1.Text = $@"{string.Join(" ", _numbers)}";
    }

    private void UpdateGraphState(GraphCard c) {
      c.chartGraph.Series[0].Color = Color.DimGray;
      c.timeLabel.Text = @"Loading...";
      c.timeLabel.Update();

      if (_numbers is null) {
        c.timeLabel.Text = @"Array is empty!";

        return;
      }

      c.chartGraph.Series[0].Points.DataBindY(_numbers);
    }

    private void UpdateGraph(GraphCard chart, int[] arr, int index) {
      chart.timeLabel.Text =
        $@"Time: {(double)_stopWatch.ElapsedMilliseconds / 1000:f7} s";
      chart.timeLabel.Update();

      chart.chartGraph.Series[0].Points.DataBindY(arr);
      chart.chartGraph.Series[0].Color = Color.DimGray;

      if (index != -1) {
        chart.chartGraph.Series[0].Points[index].Color = Color.Red;
      }

      chart.Update();
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e) {
      _isVisualizingEnabled = !checkBox1.Checked;
    }

    #endregion

    #region helper methods

    public static int[] ReplaceArrayValues(int[] arr, int i, int n,
      int[] replacement) {
      if (arr == null || replacement == null || i < 0 || i >= arr.Length ||
          n < 0 || n > arr.Length - i) {
        return arr;
      }

      for (int j = 0; j < n; j++) {
        if (i + j < arr.Length) {
          arr[i + j] = replacement[j];
        }
      }

      return arr;
    }

    private bool IsSorted(int[] array) {
      for (int i = 0; i < array.Length - 1; i++) {
        if (array[i] > array[i + 1]) {
          return false;
        }
      }

      return true;
    }

    private int[] Shuffle(int[] array) {
      Random rnd = new Random();

      for (int i = 0; i < array.Length; i++) {
        int randomPosition = rnd.Next(0, array.Length);
        int temp = array[i];

        if (_isVisualizingEnabled) {
          UpdateGraph(_charts["Bogo"], array, i);
        }

        array[i] = array[randomPosition];
        array[randomPosition] = temp;
      }

      return array;
    }

    #endregion

    #region sorting Algorithms

    private void InsertionSort(int[] arr) {
      _stopWatch.Reset();
      _stopWatch.Start();

      int currentVal;

      for (int i = 1; i < arr.Length; i++) {
        currentVal = arr[i];
        int j;

        for (j = i - 1; j >= 0 && arr[j] > currentVal; j--) {
          arr[j + 1] = arr[j];

          if (_isVisualizingEnabled) {
            UpdateGraph(_charts["Insertion"], arr, j);
          }
        }

        arr[j + 1] = currentVal;
      }

      _stopWatch.Stop();
    }

    private void SelectionSort(int[] array) {
      _stopWatch.Reset();
      _stopWatch.Start();

      int n = array.Length;

      for (int i = 0; i < n; i++) {
        int minIndex = i;

        for (int j = i + 1; j < n; j++)
          if (array[j] < array[minIndex]) {
            minIndex = j;

            if (_isVisualizingEnabled) {
              UpdateGraph(_charts["Selection"], array, j);
            }
          }

        int temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
      }

      _stopWatch.Stop();
    }

    private void BubbleSort(int[] array) {
      _stopWatch.Reset();
      _stopWatch.Start();

      int temp;

      for (int j = 0; j < array.Length; j++)
      for (int i = 0; i < array.Length - 1 - j; i++) {
        if (array[i] > array[i + 1]) {
          temp = array[i];
          array[i] = array[i + 1];
          array[i + 1] = temp;
        }

        if (_isVisualizingEnabled) {
          UpdateGraph(_charts["Bubble"], array, i);
        }
      }

      _stopWatch.Stop();
    }

    private int[] MergeSort(int[] array, int leftBoundary, int rightBoundary) {
      if (rightBoundary - leftBoundary < 2)
        return new[] { array[leftBoundary] };

      int middleIndex = leftBoundary + (rightBoundary - leftBoundary) / 2;
      int[] leftArray = MergeSort(array, leftBoundary, middleIndex);
      int[] rightArray = MergeSort(array, middleIndex, rightBoundary);

      int[] result = new int[leftArray.Length + rightArray.Length];

      int leftIndex = 0;
      int rightIndex = 0;
      int index = 0;

      for (;
           leftIndex < leftArray.Length && rightIndex < rightArray.Length;
           index++)
        if (leftArray[leftIndex] < rightArray[rightIndex]) {
          result[index] = leftArray[leftIndex];
          leftIndex++;
        } else {
          result[index] = rightArray[rightIndex];
          rightIndex++;
        }

      while (leftIndex < leftArray.Length) {
        result[index++] = leftArray[leftIndex++];
      }

      while (rightIndex < rightArray.Length) {
        result[index++] = rightArray[rightIndex++];
      }

      if (_isVisualizingEnabled)
        UpdateGraph(_charts["Merge"],
          ReplaceArrayValues(_numbersCopy, leftBoundary, result.Length, result),
          leftBoundary);

      return result;
    }

    private void QuickSort(int[] array, int left, int right) {
      if (left > right) {
        return;
      }

      Random rnd = new Random();
      int pivotIndex = rnd.Next(left, right);
      int pivot = array[pivotIndex];

      int temp = array[left];
      array[left] = array[pivotIndex];
      array[pivotIndex] = temp;

      int i = left + 1;
      int j = right;

      while (i <= j) {
        while (i <= j && array[i] <= pivot) {
          i++;
        }

        while (i <= j && array[j] >= pivot) {
          j--;
        }

        if (i < j) {
          temp = array[i];
          array[i] = array[j];
          array[j] = temp;
        }

        if (_isVisualizingEnabled)
          UpdateGraph(_charts["Quick"], array, i - 1);
      }


      temp = array[left];
      array[left] = array[j];
      array[j] = temp;

      QuickSort(array, left, j - 1);
      QuickSort(array, j + 1, right);
    }

    private void HeapSort(int[] array) {
      _stopWatch.Reset();
      _stopWatch.Start();
      int size = array.Length;

      if (size <= 1) {
        return;
      }

      for (int index = size / 2 - 1; index >= 0; index--) {
        Heapify(array, size, index);
      }

      for (int i = size - 1; i >= 0; i--) {
        var tempVar = array[0];
        array[0] = array[i];
        array[i] = tempVar;
        Heapify(array, i, 0);

        if (_isVisualizingEnabled) {
          UpdateGraph(_charts["Heap"], array, i);
        }
      }

      _stopWatch.Stop();
    }

    private void Heapify(int[] array, int size, int index) {
      var largestIndex = index;
      var leftChild = 2 * index + 1;
      var rightChild = 2 * index + 2;

      if (leftChild < size && array[leftChild] > array[largestIndex]) {
        largestIndex = leftChild;
      }

      if (rightChild < size && array[rightChild] > array[largestIndex]) {
        largestIndex = rightChild;
      }

      if (largestIndex != index) {
        var tempVar = array[index];
        array[index] = array[largestIndex];
        array[largestIndex] = tempVar;
        Heapify(array, size, largestIndex);
      }
    }

    private void GnomeSort(int[] array) {
      _stopWatch.Reset();
      _stopWatch.Start();

      int index = 0;

      while (index < array.Length) {
        if (index == 0) {
          index++;
        }

        if (_isVisualizingEnabled) {
          UpdateGraph(_charts["Gnome"], array, index);
        }

        if (array[index] >= array[index - 1]) {
          index++;
        } else {
          int temp = 0;
          temp = array[index];
          array[index] = array[index - 1];
          array[index - 1] = temp;
          index--;
        }
      }

      _stopWatch.Stop();
    }

    private void Flip(int[] array, int index) {
      int temp, start = 0;

      while (start < index) {
        temp = array[start];
        array[start] = array[index];
        array[index] = temp;
        start++;
        index--;
      }
    }

    private void PancakeSort(int[] array, int length) {
      if (length == 1) {
        return;
      }

      int mi = 0;

      for (int i = 0; i < length; i++) {
        if (array[i] > array[mi]) {
          mi = i;
        }

        if (_isVisualizingEnabled) {
          UpdateGraph(_charts["Pancake"], array, i);
        }
      }

      if (mi != 0) {
        Flip(array, mi);
      }

      Flip(array, length - 1);
      PancakeSort(array, length - 1);

    }

    #endregion
  }
}