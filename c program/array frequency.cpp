#include<stdio.h>
int main()
{
int i,j,arr[5],freq[5],count;
for(i=0;i<5;i++)
	{
		printf("enter number :");
		scanf("%d",&arr[i]);
		freq[i]=-1;
			
		}
		for(i=0;i<5;i++)
		{
			count=1;
			for(j=i+1;j<5;j++)
		{
		if(arr[i]<=arr[j])
		{
			count++;
			freq[j]=0;
		}
	}
	if(freq[i]!=0)
	{
		freq[i]=count;
	}
}
for(i=0;i<5;i++)
{
if(freq[i]!=0)
{
	printf("\n frequency of %d %d",arr[i],freq[i]);
	
}
}
}




















