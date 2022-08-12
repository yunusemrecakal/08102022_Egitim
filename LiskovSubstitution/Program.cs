public class Canlı
{
    public int Id { get; set; }
    public string Name { get; set; }
    public void Feed()
    {
        //beslen
    }
    public void Live()
    {
        //yaşa
    }

}

public class Human : Canlı
{
    public double Heigth { get; set; }
    public double Weigth { get; set; }
}