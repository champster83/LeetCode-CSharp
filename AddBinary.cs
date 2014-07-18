//Given two binary strings, return their sum (also a binary string).
  //For example,
  //a = "11"
  //b = "1"
  //Return "100". 

  //Solution: Starting from the nth character of both strings a & b, add each bit & carry forward any carry
  
   public String AddBinary(String a, String b) 
   {
      if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
        return null;
      int c = 0,i=a.Length-1 , j = b.Length-1;
      StringBuilder sum = new StringBuilder();
      while (i >= 0 || j >= 0 || c > 0)
      {
          int ac = i >= 0 ? a[i--] - '0' : 0;
          int bc = j >= 0 ? b[j--] - '0' : 0;
          int s = ac + bc + c;
          sum.Insert(0, s % 2);
          c = s / 2;
      }
      return sum.ToString();
  }
