class Program {
    static void Main(string[] args) {
    
    int n = int.Parse(Console.ReadLine()); //จำนวนโหนดในกราฟที่ไม่มีทิศทาง
    
    List<List<int>> g = new List<List<int>>();
    for(int i=0; i<n; i++) {
        List<int> temp = new List<int>();
        g.Add(temp);
    }

    while(true) {
        int i = int.Parse(Console.ReadLine());
        if(i>=n) {
            break;
        }
        else if(i<0) {
            break;
        }
        
        int j = int.Parse(Console.ReadLine());
        if(j>=n) {
            break;
        }
        else if(j<0) {
            break;
        }

        if(i==j) {
            break;
        }

        g[i].Add(j);
        g[j].Add(i);
    }


    int[] color = new int[n];

    for(int i=0; i<n; i++) {
        foreach (int edge in g[i]) {
            if(color[i] == color[edge]) {
                color[edge] += 1;
            }
        }
    }

    int max = -100;
    for(int i=0; i<n; i++) {
        if(color[i] >= max) {
            max = color[i];
        }
    }

    Console.WriteLine(max+1);
    }
}