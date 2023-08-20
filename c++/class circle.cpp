#include<iostream>
using namespace std;
class circle
{
	public:
		int radius;
		float area()
		{
			float a=3.14f*radius*radius;
			return a;                                        
		}
		float circu()             
		{                                           
		                                                                                                             
	    float  c=2*3.14f*radius;
			return c;
		}
		
		};
		int main()
		{
			float result;
			circle c1;
			cout<<"enter radius=";
			cin>>c1.radius;
			result=c1.area();
			cout<<"Area is="<<result<<endl;
			result=c1.circu();     
			cout<<"circumference is="<<result<<endl;
			return 0;
		 } 

