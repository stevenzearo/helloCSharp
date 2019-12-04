namespace ConsoleApp2 {
    public class Student : Person {
        private double _score;

        public Student(string name, int age, double score) : base(name, age) {
            Age = age;
            Name = name;
            _score = score;
        }

        public override string ToString() {
            return $"name: {Name}, age: {Age}, score: {_score}";
        }
        
        
    }
}