﻿using System;

namespace Homework2
{
	class ProgramHomework
	{
		static void Main()
		{
			// Реализовать алгоритм пирамидальной сортировки (сортировка кучей).
			System.Console.WriteLine("Please enter length of the array: ");
			int length = Convert.ToInt32(Console.ReadLine());
			PlusCounter counter = new PlusCounter();
			int[] arr = counter.randomArray(length);
			counter.showArr(arr);
			int n = arr.Length;
			sort(arr);
			System.Console.WriteLine();
			counter.showArr(arr);
		}
		public static void sort(int[] arr)
		{
			int n = arr.Length;

			// Построение кучи (перегруппируем массив)
			for (int i = n / 2 - 1; i >= 0; i--)
				heapify(arr, n, i);

			// Один за другим извлекаем элементы из кучи
			for (int i = n - 1; i >= 0; i--)
			{
				// Перемещаем текущий корень в конец
				int temp = arr[0];
				arr[0] = arr[i];
				arr[i] = temp;

				// вызываем процедуру heapify на уменьшенной куче
				heapify(arr, i, 0);
			}
		}

		// Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
		// индексом в arr[]. n - размер кучи

		public static void heapify(int[] arr, int n, int i)
		{
			int largest = i;
			// Инициализируем наибольший элемент как корень
			int l = 2 * i + 1; // left = 2*i + 1
			int r = 2 * i + 2; // right = 2*i + 2

			// Если левый дочерний элемент больше корня
			if (l < n && arr[l] > arr[largest])
				largest = l;

			// Если правый дочерний элемент больше, чем самый большой элемент на данный момент
			if (r < n && arr[r] > arr[largest])
				largest = r;

			// Если самый большой элемент не корень
			if (largest != i)
			{
				int swap = arr[i];
				arr[i] = arr[largest];
				arr[largest] = swap;

				// Рекурсивно преобразуем в двоичную кучу затронутое поддерево
				heapify(arr, n, largest);
			}
		}

	}
}
