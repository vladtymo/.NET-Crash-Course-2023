class Wars{
    List<CombatVehicle> team1 = new List<CombatVehicle>();
    List<CombatVehicle> team2 = new List<CombatVehicle>();
    
    public void addCombatVehicle(CombatVehicle bm,int team = 1){
        switch(team){
            case 1: team1.Add(bm);break;
            case 2: team2.Add(bm);break;
            default: System.Console.WriteLine("Only 1 or 2");break;
        }
    }
    public bool Round(CombatVehicle bm1,CombatVehicle bm2){
        Console.ForegroundColor = ConsoleColor.Blue;
        bm1.ShowInfo();
        bm2.ShowInfo();
        Console.ForegroundColor = ConsoleColor.White;
        int round = 1;
        while(true){
            System.Console.WriteLine($"----Round{round}----");
            System.Console.WriteLine($"{bm1.Type} {bm1.Model} Attacking {bm1.Attack()}");
            bm2.Defence(bm1.Attack());
            System.Console.WriteLine($"{bm2.Type} {bm2.Model} Defending, Health: {bm2.Health}");
            if(bm2.isDestroyed()){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{bm1.Type} {bm1.Model} Winning");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
                
            }
            System.Console.WriteLine($"{bm2.Type} {bm2.Model} Attacking {bm2.Attack()}");
            bm1.Defence(bm2.Attack());
            System.Console.WriteLine($"{bm1.Type} {bm1.Model} Defending, Health: {bm1.Health}");
            if(bm1.isDestroyed()){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{bm2.Type} {bm2.Model} Winning");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            ++round;
        }
    }
    public void Battle(){
        System.Console.WriteLine("-------------TEAM1-------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        foreach (var bm in team1)
        {
            bm.ShowInfo();
        }
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine("-------------TEAM2-------------");
        Console.ForegroundColor = ConsoleColor.Magenta;
        foreach (var bm in team2)
        {
            bm.ShowInfo();
        }
        Console.ForegroundColor = ConsoleColor.White;
        int battle = 1;
        while(team1.Count() > 0 && team2.Count() > 0){
            Random rand = new Random();
            int team1BmIndex = rand.Next(0, team1.Count());
            int team2BmIndex = rand.Next(0, team2.Count());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine($"------Battle №{battle}------");
            Console.ForegroundColor = ConsoleColor.White;
            bool res = Round(team1[team1BmIndex],team2[team2BmIndex]);
            if(res){
                team2.RemoveAt(team2BmIndex);
            }else{
                team1.RemoveAt(team1BmIndex);
            }
            ++battle;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(team1.Count() == 0 ? "Team2 WINS" : "Team1 WINS"); 
        Console.ForegroundColor = ConsoleColor.White;

        
    }
}