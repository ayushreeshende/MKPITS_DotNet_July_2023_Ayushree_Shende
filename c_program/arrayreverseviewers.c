#include<stdio.h>
void main()
{
	int i,n,nums[100];
	printf("enter n:");
	scanf("%d",&n);
//	accepting values
	for(i=0;i<n;i++)
	{
		printf("enter marks:");
		scanf("%d",&nums[i]);
			
		
		}
		for(i=n-1;i>=0;i--)
		{
		printf("%d",nums[i]);
			}
}
