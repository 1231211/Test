namespace ConsoleApp1
{
    /// <summary>
    /// 分页对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FastPage<T>
    {
        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalCount { get; set; } = 0;

        /// <summary>
        /// 页码
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// 每页数量
        /// </summary>
        public int Size { get; set; } = 10;

        /// <summary>
        /// 数据
        /// </summary>
        public List<T> Data { get; set; } = new List<T>();
    }
}
