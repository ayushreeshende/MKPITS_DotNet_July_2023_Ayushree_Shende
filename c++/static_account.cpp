#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		static float roi;
		account(int actno,int bal)
		{
			this->actno=actno;
			this->bal=bal;
		}
		void display()
		{
			cout<<"actno"<<actno<<endl;
			cout<<"bal"<<bal<<endl;
			cout<<"rate of interest"<<roi<<endl;
			
		}
		
};
float account::roi=9.5f;
int main()
{
	account A1=account(123,2000);
	account A2=account(234,4000);
	A1.display();
	A1.display();
	return 0;
}

