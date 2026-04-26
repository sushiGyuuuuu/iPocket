public class InterestManager
{
    private double baseRate = 0.01; // 1%

    public double GetAnnualRate(int year)
    {
        return baseRate * year; // + 1% per year
    }

    public double Incrementrate(double currentRate)
    {
        return currentRate + 0.01;
    }
}