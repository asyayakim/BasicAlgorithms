# Sorting Algorithms Comparison in C#

A console application demonstrating and benchmarking three fundamental sorting algorithms with detailed space complexity analysis.

## Features
- Implementation of three core sorting algorithms:
  - QuickSort (with partition scheme)
  - Merge Sort (with efficient array merging)
  - Bubble Sort (basic version)
- Execution time benchmarking using `Stopwatch`
- Space complexity analysis documentation
- Random data generation for testing
- Array cloning to ensure fair comparisons

## Algorithms Implemented

### QuickSort
- **Type**: Divide-and-conquer
- **Average Time**: O(n log n)
- **Worst Case**: O(n²)
- **Implementation**: Recursive with in-place sorting

### Merge Sort
- **Type**: Divide-and-conquer
- **Time**: O(n log n) guaranteed
- **Space**: O(n) auxiliary
- **Features**: Stable sorting, external sorting capability

### Bubble Sort
- **Type**: Comparison-based
- **Time**: O(n²)
- **Space**: O(1)
- **Feature**: Simple in-place implementation

## Complexity Analysis
| Algorithm      | Time Complexity (Best) | Time Complexity (Avg) | Time Complexity (Worst) | Space Complexity |
|----------------|------------------------|-----------------------|-------------------------|------------------|
| **QuickSort**  | O(n log n)             | O(n log n)            | O(n²)                   | O(log n)         |
| **Merge Sort** | O(n log n)             | O(n log n)            | O(n log n)              | O(n)             |
| **Bubble Sort**| O(n)                   | O(n²)                 | O(n²)                   | O(1)             |

## Installation
1. Ensure [.NET SDK 6.0+](https://dotnet.microsoft.com/download) is installed
2. Clone repository:
```bash
git clone https://github.com/yourusername/sorting-algorithms-comparison.git
