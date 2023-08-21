#include<iostream>
using namespace std;
int main()
{
	int num1,num2,result=0;
	char op;
	cout<<"Enter 2 numbers";
	cin>>num1>>num2;
	cout<<"enter (+,-,*,/)";
	cin>>op;
	fflush(stdin);
	switch(op)
{
		case '+':
			result=num1+num2;
			break;
			case '-':
			result=num1-num2;
				break;
				case '*':
					result=num1*num2;
						break;
					case '/':
					result=num1/num2;
						break;
}
cout<<"result="<<result;
return 0;
}

