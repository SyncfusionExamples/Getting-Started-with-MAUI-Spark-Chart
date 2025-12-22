namespace SparkChartSample
{
    internal class ViewModel
    {
        public List<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Model>
            {
                new Model(){ Value = 5000},
                new Model(){ Value = 9000},
                new Model(){ Value = 5000},
                new Model(){ Value = 1000},
                new Model(){ Value = 3000},
                new Model(){ Value = -4000},
                new Model(){ Value = 5000},
                new Model(){ Value = -2000},
                new Model(){ Value = 8000}
            };
        }
    }
}
