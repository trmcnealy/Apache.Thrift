

namespace Apache.Thrift.Database
{
    public enum TResultSetLayout
    {
        GroupByPerfectHash  = 0,
        GroupByBaselineHash = 1,
        Projection          = 2,
        NonGroupedAggregate = 3,
    }
}
