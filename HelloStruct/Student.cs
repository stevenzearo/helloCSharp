namespace HelloStruct {
    public struct Student {
        public string Name;
        public int Age;
        public double Score;

        public Student(string name, int age, double score) {
            Name = name;
            Age = age;
            Score = score;
        }

        public override string ToString() {
            return $"name: {Name}, age: {Age}, score: {Score}";;
        }
    }
}