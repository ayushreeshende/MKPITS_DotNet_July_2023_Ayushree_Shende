#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		int interest;
		void getdata(int a,int b,int c)
		{
			actno=a;
			bal=b;
			interest=c;
			
		}
};
class saving:public account
{
	public:
		int deposite(int amt)
		{
			bal=bal+interest+amt;
			return bal;
		}
};
class current:public account
{
	public:
		int deposite(int amt)
		{
			bal=bal+amt;
			return bal;
		}
};
int main()
{
	saving s1;
	current c1;
	int result,actno,bal,interest,amount;
	cout<<"enter actno,bal,int,amt:";
	cin>>actno>>bal>>interest>>amount;
	s1.getdata(actno,bal,interest);
	result=s1.deposite(amount);
	cout<<"saving account"<<result<<endl;
	c1.getdata(actno,bal,interest);
	result=c1.deposite(amount);
	cout<<"current amount"<<result;
	return 0;
	
}
