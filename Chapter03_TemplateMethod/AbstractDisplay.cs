namespace Chapter03_TemplateMethod
{
    /// <summary>
    /// メソッドDisplayのみ実装されている抽象クラス
    /// </summary>
    public abstract class AbstractDisplay
    {
        protected abstract void Open();
        protected abstract void Print();
        protected abstract void Close();

        public void Display()
        {
            Open();

            for (var i = 0; i < 5; i++)
            {
                Print();
            }

            Close();
        }
    }
}
