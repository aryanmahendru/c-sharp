//Student grade assignment
int sum=0;
int h=100;
int g=0;
int e=0;
Random rnd = new Random();
int[] a = new int[35];
for (int x = 0; x < 35; x++) {
	a[x]=rnd.Next(100);
}

bool loop = true;
while (loop) {
	Console.WriteLine("1 Display All Grades");
	Console.WriteLine("2 Display Honours");
	Console.WriteLine("3 Stats");
	Console.WriteLine("4 Randomize Grades");
	Console.WriteLine("5 Exit");
	string z = Console.ReadLine();

	if (z == "1") {
		Console.WriteLine("ALL GRADES");
		for (int y = 0; y < 35; y++) {
			Console.WriteLine(a[y]+"%");
		}
	} else if (z=="2") {
		Console.WriteLine("HONOURS");
		for (int d = 0; d < 35; d++) {
			if (a[d]>=80) {
				Console.WriteLine(a[d]+"%");
				e++;
			}
		}
		Console.WriteLine("Number of Honours: "+e);
	} else if (z=="3") {
		Console.WriteLine("STATS");

		for (int f = 0; f < 35; f++) {
			if(a[f]>g) {
				g=a[f];
			}
		}
	
		Console.WriteLine("Highest Grade: "+g+"%");
	
		for (int i = 0; i < 35; i++) {
			if (a[i]<h) {
				h=a[i];
			}
		}
		Console.WriteLine("Lowest Grade: "+h + "%");

		for (int j = 0; j < 35; j++) {
			sum+=a[j];
		}
		int l=sum/35;
		Console.WriteLine("Average Grade: "+l+"%");
		
	}
     else if (z == "4") {
      Random r = new Random();
	  for (int o = 0; o < 35; o++) {
	a[o]=r.Next(100);
    
	 
	}
    Console.WriteLine("GRADES HAVE BEEN RANDOMIZED");
    }	

    else if (z == "5") {
		loop=false;
		Console.WriteLine("Bye");
	}	


	
}

