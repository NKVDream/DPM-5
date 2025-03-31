using System;
class PhotoBook
{
    public string Photo1 { get; set; }
    public string Photo2 { get; set; }
    public int Date1 { get; set; }
    public int Date2 { get; set; }
    public bool Attitude {  get; set; }
    public PhotoBook(string photo1, int date1)
    {
        Photo1 = photo1;
        Date1 = date1;
        Console.WriteLine($"you got only one photo.\t 1){photo1}:{date1}.");
    }
    public PhotoBook(string photo1, int date1, string photo2, int date2)
    {
        Photo1 = photo1;
        Photo2 = photo2;
        Date1 = date1;
        Date2 = date2;
        Console.WriteLine($"you got two photos.\t 1){photo1}:{date1}; 2){photo2}:{date2}.");
    }
    public PhotoBook(string photo1, int date1, bool attitude)
    {
        Photo1 = photo1;
        Date1 = date1;
        Attitude = attitude;
        Console.WriteLine($"you got photo with mark.\t 1){photo1}:{date1}. Should i go there again?:{attitude}!");
    }
}