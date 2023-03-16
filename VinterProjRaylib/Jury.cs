
public class Jury
{
    //kolla om jag kan göra så att olika ingredienser ger olika mängd likeability hos tre olika judges, 
    //liksom att en morot get +3 i en maträtt hos en judge men ger bara +1 eller negativ rating av en annan.
    //Det kommer vara så att om man får tillräckligt med Taste poäng så blir happy = true eller nå.
    public bool happy = false;

    public int taste = 0;

    public void tasting(Dish dish)
    {
        // taste = fråga micke, men den ska leda till dish(get taste) typ

        if (taste >= 10)
        {
            happy = true;

        }

        else if (taste <= 10)
        {
            happy = false;
        }
    }

}
