﻿   int time = DateTime.Now.Hour;
   if (time >= 6 && time < 11)
   Console.WriteLine("Günaydınn!");
  

    else if(time<= 18)
    
      Console.WriteLine("İyi Günler");
    
    else
        Console.WriteLine("İyi geceler");
   
    string sonuc = time<=18 ? "İyi günler" : "İyi geceler";
    sonuc = time >= 6 && time < 11  ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi geceler";
    Console.WriteLine(sonuc);
    

