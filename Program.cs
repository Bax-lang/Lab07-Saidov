//          string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

//          for (int i = days.Length - 1; i >= 0; i--) {
//              Console.WriteLine($"{i}: {days[i]}");
//          }

//         Задание 1.2
//        double[] temps = { -5.2, -1.0, 2.5, 4.0, -3.5, 0.0, 1.2 };

//        foreach (double t in temps) {
//            Console.Write(t + " ");
//        }

//        Задание 2
//       int[] prices = { 120, 45, 300, 80, 15, 210 };
//       int sum = 0;
//       int count = 0;

//       foreach (int price in prices) {
//           sum += price;
//           if (price > 100) {
//               count++;
//           }
//       }

//       double average = (double)sum / prices.Length;
//       Console.WriteLine($"Сумма: {sum}");
//       Console.WriteLine($"Средняя цена: {average}");
//       Console.WriteLine($"Дороже 100: {count}");

//       Задание 3
//      int[] prices = { 120, 45, 300, 80, 15, 210 };
//      int min = prices[0];
//      int max = prices[0];
//      int maxIndex = 0;

//      for (int i = 1; i < prices.Length; i++) {
//          if (prices[i] < min) {
//              min = prices[i];
//          }
//          if (prices[i] > max) {
//              max = prices[i];
//              maxIndex = i;
//          }
//      }

//      Console.WriteLine($"Минимум: {min}");
//      Console.WriteLine($"Индекс самого дорогого: {maxIndex}");

//      Задание 4
//     int[] balance = { 100, -50, 20, -5, 0, 75 };

//     for (int i = 0; i < balance.Length; i++) {
//         if (balance[i] < 0) {
//             balance[i] = 0;
//         }
//     }

//     foreach (int b in balance) {
//         Console.Write(b + " ");
//     }

//     Задание 5
//    int[] nums = new int[5];
//    int evenCount = 0;

//    for (int i = 0; i < nums.Length; i++) {
//        Console.Write($"Введите число {i + 1}: ");
//        nums[i] = Convert.ToInt32(Console.ReadLine());
//        if (nums[i] % 2 == 0) {
//            evenCount++;
//        }
//    }

//    Console.Write("В обратном порядке: ");
//    for (int i = nums.Length - 1; i >= 0; i--) {
//        Console.Write(nums[i] + " ");
//    }
//    Console.WriteLine($"\nЧётных чисел: {evenCount}");

//    Задание 6
//   string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
//   Console.Write("Введите имя для поиска: ");
//   string search = Console.ReadLine();
//   bool found = false;

//   for (int i = 0; i < names.Length; i++) {
//       if (names[i] == search) {
//           Console.WriteLine($"Найдено на позиции (индекс): {i}");
//           found = true;
//           break;
//       }
//   }

//   if (!found) {
//       Console.WriteLine("Не найдено");
//   }

//   Итоговая задача
//  int[] grades = { 5, 4, 5, 3, 5, 4, 2, 5 };

//  Console.Write("Все оценки: ");
//  foreach (int g in grades) {
//      Console.Write(g + " ");
//  }
//  Console.WriteLine();

//  int sumGrades = 0;
//  int maxGrade = grades[0];
//  int minGrade = grades[0];
//  int count2 = 0;
//  int count5 = 0;

//  for (int i = 0; i < grades.Length; i++) {
//      sumGrades += grades[i];
//      if (grades[i] > maxGrade) {
//          maxGrade = grades[i];
//      }
//      if (grades[i] < minGrade) {
//          minGrade = grades[i];
//      }
//      if (grades[i] == 2) {
//          count2++;
//      }
//      if (grades[i] == 5) {
//          count5++;
//      }
//  }

//  double avg = (double)sumGrades / grades.Length;
//  Console.WriteLine($"Средняя оценка: {avg}");
//  Console.WriteLine($"Наибольшая: {maxGrade}, наименьшая: {minGrade}");
//  Console.WriteLine($"Двоек: {count2}, пятёрок: {count5}");

//  if (avg >= 4.5) {
//      Console.WriteLine("Отличник");
//  }
//  else if (avg >= 3.5) {
//      Console.WriteLine("Хорошист");
//  }
//  else {
//      Console.WriteLine("Есть над чем поработать");
//  }

//  Дополнительное задание
 int[] arr = { 1, 2, 3, 4, 5, 6 };

 for (int i = 0; i < arr.Length / 2; i++) {
     int temp = arr[i];
     arr[i] = arr[arr.Length - 1 - i];
     arr[arr.Length - 1 - i] = temp;
 }

 foreach (int x in arr) {
     Console.Write(x + " ");
 }
