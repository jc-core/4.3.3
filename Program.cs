namespace Assignment4_3_3 {
    internal class Program {

        static void Main(string[] args) {

            List<int> numbers = ReadNumbers();

            Dictionary<int, int> results = new();

            foreach (int number in numbers) {
                if (results.ContainsKey(number))
                    results[number]++;
                else
                    results[number] = 1;
            }

            List<int> singles = new();

            foreach (var result in results) {
                if (result.Value == 1) singles.Add(result.Key);
            }

            Console.WriteLine();
            if (singles.Count == 0)
                Console.WriteLine("Every number in the list repeats at least once.");
            else
                Console.WriteLine($"Numbers that appear only once: {string.Join(", ", singles)}");

        }

        static List<int> ReadNumbers() {

            while (true) {

                Console.Write("Type some whole numbers separated by spaces: ");
                string[] nums = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);

                List<int> numbers = new();
                foreach (string num in nums) {
                    if (int.TryParse(num, out int value))
                        numbers.Add(value);
                }

                if (numbers.Count > 0 && numbers.Count == nums.Length)
                    return numbers;

                Console.WriteLine("Need at least one number, and only whole numbers.");

            }

        }
    }
}
