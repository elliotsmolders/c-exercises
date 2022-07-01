class Helpers
{
    public int GroteSom(params int[] getallen){
        return getallen.Aggregate(0,(total,current)=>total+current);
    }
}