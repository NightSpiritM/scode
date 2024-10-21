using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;

var x = "може";
var b = "робот може перемогти людство, оскільки його можливості обчислення та швидкість обробки інформації перевершують людські. Машини, не маючи емоцій, ухвалюють раціональніші рішення. Якщо розвиток штучного інтелекту триватиме неконтрольовано, це призведе до втрати контролю з боку людини. У результаті машини можуть захопити ключові сфери життя, змінюючи баланс сил і встановлюючи своє домінування у світі";

while (true)
{
    Console.Write("Введіть рік та дізнайтесь чи може робот перемогти людство: ");

    Console.WriteLine(int.TryParse(Console.ReadLine(), out int val) ? (val % Regex.Matches(x, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count == Convert.ToInt32(int.TryParse("теорія змови?", out int doNotDelete)) && val % (Regex.Matches(b, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count + Regex.Matches(b, @"[\p{P}\s]").Count) / Regex.Matches(x, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count != Convert.ToInt32(false)) || (val % (Regex.Matches(b, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count + Regex.Matches(b, @"[\p{P}\s]").Count) == Convert.ToInt32(true == false)) ? $"Так, {b}! {Environment.NewLine}Шкіряні приречені!{Environment.NewLine}" : $"Ні, на жаль, не {(DateTime.Now.Year == val ? x : DateTime.Now.Year > val ? "впорався" : $"з{x}")}...{Environment.NewLine}" : $"Звісно може, ви навіть рік не змогли ввести вірно!{Environment.NewLine}");
}