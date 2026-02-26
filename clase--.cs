using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Persoana : ICloneable, IComparable
{
    private int id;
    private string nume;
    protected int varsta;
    public Persoana()
    {
        id = 0;
        nume = "N/A";
        varsta = 1;
    }
    public Persoana(int id, string nume, int varsta)
    {
        this.id = id;
        this.nume = nume;
        this.varsta = varsta;
    }
    public Persoana(Persoana p)
    {
        this.id = p.id;
        this.nume = p.nume;
        this.varsta = p.varsta;
    }
    //varianta 1 de get/set
    public string GetNume()
    {
        return nume;
    }
    public void SetNume(string nume)
    {
        this.nume = nume;
    }
    //varianta 2 de get/set
    public int Id { get => id; set => id = value; }
    public string Nume { get => nume; set => nume = value; }
    public int Varsta { get => varsta; set => varsta = value; }
    public override string? ToString()
    {
        return "id: " + id + "\nnume:" + nume + "\nvarsta:" + varsta;
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public int CompareTo(object? obj)
    {
        Persoana p = (Persoana)obj;
        if (this.id > p.id) 
            return 1;
        else if(this.id < p.id) 
            return -1;
        else return 0;
    }
    internal class Student : Persoana
    {
        private float medieAni = 0;
        public Student() : base() { 
            medieAni = 0.0f;
        }
        public Student(float medieAni)
        {
            this.medieAni = medieAni;
        }
        public float MedieAni { get => medieAni; set => medieAni = value; }
        public override string? ToString()
        {
            return base.ToString() + "\nmedie ani: " + medieAni;
        }
        public static Student operator+(Student stud, float valoare)
        {
            stud.medieAni = valoare + stud.medieAni;
            return stud;
        }
        public static Student operator+(float valoare, Student stud)
        {
            stud.medieAni = valoare + stud.medieAni;
            return stud;
        }

    }
}

