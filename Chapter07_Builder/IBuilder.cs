namespace Chapter07_Builder
{
    /// <summary>
    /// 文章を構成するためのメソッドを定めた抽象クラス
    /// </summary>
    public interface IBuilder
    {
        public abstract void MakeTitle(string title);

        public abstract void MakeString(string str);

        public abstract void MakeItems(string[] items);

        public abstract void Close();
    }
}
