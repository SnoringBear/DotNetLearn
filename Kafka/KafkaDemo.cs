using Confluent.Kafka;

namespace DotNetLearn.Kafka;
[TestFixture]
public class KafkaDemo
{
    [Test]
    public async Task Test1()
    {
        // Kafka 配置
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092", // Kafka 服务器地址
            ClientId = "csharp-producer",
            // 确保消息持久性
            Acks = Acks.All
        };

        // 创建生产者
        using (var producer = new ProducerBuilder<Null, string>(config).Build())
        {
            try
            {
                // 要发送的消息
                string topic = "test-topic";
                string message = "Hello, Kafka from C#!";

                // 异步发送消息
                var deliveryResult = await producer.ProduceAsync(topic, 
                    new Message<Null, string> { Value = message });

                // 打印发送结果
                Console.WriteLine($"Message delivered to {deliveryResult.TopicPartitionOffset}");
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Delivery failed: {e.Error.Reason}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

    }
}