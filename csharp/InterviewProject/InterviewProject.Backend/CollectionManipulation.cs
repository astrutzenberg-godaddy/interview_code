namespace InterviewProject.Backend;

public static class CollectionManipulation
{
    public static IList<int> DeDupe(IList<int> list)
    {
        List<int> result = new List<int>();
        foreach(int l in list) {

            if (!result.Contains(l))
            {
                result.Add(l);
            }
        }

        return result;
        //throw new NotImplementedException("Implement Me");
    }

    #region General Case
    public static IList<T> GeneralDedupe<T>(IList<T> list)
    {
        throw new NotImplementedException("Implement Me");
    }
    #endregion

}
