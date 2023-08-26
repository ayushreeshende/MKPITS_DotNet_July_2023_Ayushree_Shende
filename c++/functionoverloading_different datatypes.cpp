#include<iostream>
using namespace std;
class calculation
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		float add(float n1,float n2)
		{
			return n1+n2;
			
		}
};
int main()
{
	calculation c;
	cout<<"addition of int"<<c.add(2,3)<<endl;
	cout<<"addition of float"<<c.add(2.2,3.5f);
	return 0;
}
