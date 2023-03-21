// See https://aka.ms/new-console-template for more information
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDate;

    public SimpleDataBase()
    {
        this.storedData= new List<T>();
        this.inputDate= new List<DateTime>();
    }

    public void addNewData(T newData)
    {
        this.inputDate.Add(DateTime.Now);
        this.storedData.Add(newData);

    }
    public void PrintAllData()
    {
        for(int i = 0; i < this.inputDate.Count; i++)
        {
            Console.WriteLine("Data " + i + " bersisi " + this.storedData[i] + " yang disimpan pada waktu UTC: " + this.inputDate[i]);
        }
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        SimpleDataBase<float> dataBase = new SimpleDataBase<float>();
        dataBase.addNewData(13);
        dataBase.addNewData(20);
        dataBase.PrintAllData();


    }
}
