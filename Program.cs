namespace ArvMedReidar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rockingchair ivar = new Rockingchair();
            ivar.PrintInfo(); ivar.Rocking(); ivar.Profit();
            Barstool bertil = new Barstool();
            bertil.PrintInfo(); bertil.Profit();
            Conferencechair helga = new Conferencechair();
            helga.PrintInfo(); helga.Profit();
            Deskchair hildur = new Deskchair();
            hildur.PrintInfo(); hildur.Profit();

            SingleBed lars = new SingleBed(8995, "steel", 2000, "lars", 4);
            DoubleBed johan = new DoubleBed(13499, "wood", 2500, "johan", 3);
            SingleBed peter = new SingleBed(4999, "aluminium", 1300, "peter", 5);

            lars.PrintInfo();
            johan.PrintInfo();
            peter.PrintInfo();

            lars.Sleep(1);
            johan.Sleep(2);
            lars.Sleep(2);
            johan.Sleep(3);

            lars.Profit();
            johan.Profit();
            peter.Profit();
        }
    }
}