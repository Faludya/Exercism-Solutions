static class AssemblyLine
{
    private static int CARS = 221;
    public static double SuccessRate(int speed)
    {
        if(speed == 0){
            return 0.0d;
        }
        else if(speed >= 1 && speed <= 4){
            return 1.0d;
        }
        else if(speed >= 5 && speed <= 8){
            return 0.9d;
        }
        else if(speed == 9){
            return 0.8d;
        }
        else{
            return 0.77d;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return CARS * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
