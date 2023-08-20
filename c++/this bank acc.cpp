#include<iostream>
using namespace std;
class bankaccount
{
	public:
		int accno,balance;
		int getdeposit();
bankaccount(int accno,int balance);
{

this->accno=accno;
this->balance=balance;
		
			accno=accno;
			balance=balance;
		}
			 int getdeposite()
			 {
			int amt;
			cout<<"emter deposite amt:";
			cin>>amt;
			balance=balance+amt;
			cout<<"amount deposited:"<<balance<<endl;
			return amt;
		}
		int getwithdrawal()
		{
			int amt;
			cout<<"enter withdrawal amt:";
			cin>>amt;
			balance=balance-amt;
			cout<<"amount withdrawal:"<<balance<<endl;
			return amt;
		}
};
int main()
{
	int accno,balance;
	 bankaccount.b1;
	cout<<"enter accno and balance:";
	cin>>b1.accno>>b1.balance;
b1.getdeposite();
b1.getwithdrawal();
	return 0;
}


