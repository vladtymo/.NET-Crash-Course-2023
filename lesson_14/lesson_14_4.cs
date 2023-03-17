using System;
using System.Collections.Generic;

class HanoiTower{
    public Stack<int> Disks { get; }
    public HanoiTower(){
        Disks = new Stack<int>();
    }
}
class Program{
    static void Main(){
        int numDisks = 4;
        HanoiTower[] towers = new HanoiTower[3];
        for (int i = 0; i < 3; i++) towers[i] = new HanoiTower();
        for (int i = numDisks; i >= 1; i--) towers[0].Disks.Push(i);
        SolveHanoi(numDisks, towers, 0, 1, 2);
    }
    static void SolveHanoi(int numDisks, HanoiTower[] towers, int from, int to, int aux){
        if (numDisks == 1){
            int disk = towers[from].Disks.Pop();
            towers[to].Disks.Push(disk);
            Console.WriteLine($"Move disk {disk} from tower {from + 1} to tower {to + 1}");
            return;
        }
        SolveHanoi(numDisks - 1, towers, from, aux, to);
        SolveHanoi(1, towers, from, to, aux);
        SolveHanoi(numDisks - 1, towers, aux, to, from);
    }
}
