using System;


namespace Class.Employee {
    class Employee {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        //Construtor vazio
        public Employee() {}

        //Construtor
        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public void increaseSalary(double porc) {
            Salary += Salary * porc / 100.00;
        }

        public override string ToString() {
            return Id 
                + ", " 
                + Name 
                + ", " 
                + Salary;
        }

    }
}
