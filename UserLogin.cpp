//Manuel Rojas Henarejos
/* This is a program that asks the user to enter the username and 
 * password to login.
 */

#include <iostream>
#include <stdlib.h>

using namespace std;

int main()
{
    int times = 0;
    string username;
    string password;
    
    do
    {
      cout<<"Enter Username: ";
      cin>>username;
      cout<<"Enter Password: ";
      cin>>password;
      
      if (username == "admin" && password == "1234")
      {
          cout<<"Access Granted"<<endl;
          break;
      }
      else
      {
        cout<<"Wrong Credentials"<<endl;
        times++;
      }
    } while (times < 3);
    
    if (times == 3)
    {
        cout<<"Error limit exceeded"<<endl;
    }
    return 0;
}
