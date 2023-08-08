#include<stdio.h>
void main()
{
int i,j,arr[5],cnt=0;
for(i=0;i<5;i++)
	{	
		printf("enter nunbers :");
		scanf("%d",&arr[i]);
			
	}
		for(i=0;i<5;i++)
		{
			cnt=0;
			for(j=0;j<5;j++)
		{
		if(i!=j)
		{
		
		if(arr[i]==arr[j])
		{
		cnt++;
		break;
		
	}
	
	}
}
if(cnt==0)
{
	printf("\nunique=%d",arr[i]);
}
}
}

