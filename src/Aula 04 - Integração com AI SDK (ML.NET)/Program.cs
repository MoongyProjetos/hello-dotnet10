using System;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace MLNetDemo
{
    public class HouseData
    {
        public float Size { get; set; }
        public float Price { get; set; }
    }

    public class Prediction
    {
        [ColumnName("Score")]
        public float Price { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("🤖 Demo ML.NET - Regressão Linear Simples");
            var context = new MLContext();

            // Dados de treino
            var data = new[] {
                new HouseData() { Size = 1.1F, Price = 1.2F },
                new HouseData() { Size = 1.9F, Price = 2.3F },
                new HouseData() { Size = 2.8F, Price = 3.0F },
                new HouseData() { Size = 3.4F, Price = 3.7F }
            };
            var trainData = context.Data.LoadFromEnumerable(data);

            // Treinamento
            var pipeline = context.Regression.Trainers.Sdca(labelColumnName: "Price", maximumNumberOfIterations: 100);
            var model = pipeline.Fit(trainData);

            // Predição
            var size = new HouseData() { Size = 2.5F };
            var predictionEngine = context.Model.CreatePredictionEngine<HouseData, Prediction>(model);
            var prediction = predictionEngine.Predict(size);

            Console.WriteLine($"Tamanho: {size.Size} -> Preço previsto: {prediction.Price:C2}");
            Console.WriteLine("\n✅ Execução concluída.");
        }
    }
}
