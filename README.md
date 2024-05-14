## gb_final_c-sharp_task

#  Порядок решения задачи:

1. Чтобы сформировать новый массив из строк одним из способов, необходимо узнать размер нового массива, т.е. написать метод, который считает сколько элементов массива надо будет записать в новый массив (`count`). С помощью цикла (`for`) проходимся по массиву и находим строки меньше или равные 3м символам.
2. Инициализируем новый массив с уже известным размером.
3. Снова проходимся по масссиву (`foreach`), но уже записываем отфильтрованные элементы в новый массив c известным размером.
4. Тестируем метод с представленными вариантами первоначальных массивов.
5. Результат выводится в квадратных скобках, поэтому добавляем скобки в вывод.

Блок-схема приложена и также находится по [ссылке](https://app.diagrams.net/#G154KoOI_vmZma3myStUGFhuWRM2oJPYRp#%7B%22pageId%22%3A%2286_iSI6ALrsWmHpUFLUa%22%7D). *Схема составлена с учетом того, что размер нового массива уже известен.*
