#include<iostream>
using namespace std;
class animals
{
	public:
		virtual void sound()
		{
			cout<<"animals sound"<<endl;
		}
};
class dog:public animals
{
	public:
		void sound()
		{
			cout<<"dog sound is bow bow"<<endl;
		}
};
class cat:public animals
{
	public:
		void sound()
		{
			cout<<"cat sound is meow meow"<<endl;
		}
};
class cow:public animals
{
	public:
		void sound()
		{
			cout<<"cow sound is hump hump"<<endl;
		}
};
int main()
{
animals *A;
animals a1;
dog d;
cat c;
cow c1;
A=&a1;
A->sound();
A=&d;
A->sound();
A=&c;
A->sound();
A=&c1;
A->sound();
return 0;
}

