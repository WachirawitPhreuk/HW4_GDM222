class Program {
    static void Main(string[] args) {
    
    int n = int.Parse(Console.ReadLine()); //จำนวนโหนดในกราฟที่มีทิศทาง
    
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

        g[i].Add(j);
    }

    int iCheck = int.Parse(Console.ReadLine());
    int jCheck = int.Parse(Console.ReadLine());

    Queue<int> q = new Queue<int>();
    bool[] visited = new bool[n];
    
    q.Enqueue(iCheck);

    while (q.Count > 0) {
        int u = q.Dequeue();
        if(visited[u]) {
            continue;
        }
        visited[u] = true;

        foreach (int edge in g[u]) {
            if(!visited[edge]) {
                q.Enqueue(edge);
            }
        }
    }

    if(visited[jCheck] == true) {
        Console.WriteLine("Readable");
    }
    if(visited[jCheck] == false) {
        Console.WriteLine("Unreadable");
    }
    }
}