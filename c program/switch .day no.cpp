#include<stdio.h>
void main ()
{
	int day_no;
	Printf("Enter day _no:");
	scanf("%d",&day_no);
	switch(day_no)
	{
		case 1:
			printf("\nMonday");
			break;
			case 2:
				printf("\nTuesday");
				break;
				case 3:
					printf("\nWednesday");
					break;
					case 4:
						printf("\nThusday");
						break;
						case 5:
							printf("\nFriday");
							break;
							case 6:
							printf("\nSaturday");
							break;
							case 7:
								printf("\nSunday");
								break;
								default:
									printf("\nInvalid");
									break;
								}
}
