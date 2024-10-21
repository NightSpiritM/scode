using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;

var pos = "може";
var posFull = "робот може перемогти людство, оскільки його можливості обчислення та швидкість обробки інформації перевершують людські. Машини, не маючи емоцій, ухвалюють раціональніші рішення. Якщо розвиток штучного інтелекту триватиме неконтрольовано, це призведе до втрати контролю з боку людини. У результаті машини можуть захопити ключові сфери життя, змінюючи баланс сил і встановлюючи своє домінування у світі";

while (true)
{
    Console.Write("Введіть рік та дізнайтесь чи може робот перемогти людство: ");

    Console.WriteLine(int.TryParse(Console.ReadLine(), out int intYear) ? (intYear % Regex.Matches(pos, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count == Convert.ToInt32(int.TryParse("теорія змови?", out int iwtb)) && intYear % (Regex.Matches(posFull, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count + Regex.Matches(posFull, @"[\p{P}\s]").Count) / Regex.Matches(pos, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count != Convert.ToInt32(false)) || (intYear % (Regex.Matches(posFull, @"[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]").Count + Regex.Matches(posFull, @"[\p{P}\s]").Count) == 0) ? $"Так, {posFull}! {Environment.NewLine}Шкіряні приречені!{Environment.NewLine}" : $"Ні, на жаль, не {(DateTime.Now.Year == intYear ? pos : DateTime.Now.Year > intYear ? "впорався" : $"з{pos}")}...{Environment.NewLine}" : $"Звісно може, ви навіть рік не змогли ввести вірно!{Environment.NewLine}");
}