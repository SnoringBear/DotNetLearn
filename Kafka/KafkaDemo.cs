using Confluent.Kafka;

namespace DotNetLearn.Kafka;
[TestFixture]
public class KafkaDemo
{
    [Test]
    public async Task Test1()
    {
        // 创建生产者
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092", // Kafka 服务器地址
            Acks = Acks.All, 
        };
        var producer = new ProducerBuilder<String, String>(config).Build();
        while (true)
        {
            try
            {
                var deliveryResult = await producer.ProduceAsync("test-topic", new Message<String, String>
                {
                    Key = "test-topic",
                    Value = "hello",
                });
                // 4. 处理发送结果
                // -----------------
                // 发送成功后，可以获取到消息的详细信息，例如它被存储在哪个分区 (Partition) 和偏移量 (Offset)。
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                    $"消息 '{deliveryResult.Value}' 已成功发送到主题 '{deliveryResult.Topic}' 的分区 {deliveryResult.Partition}，偏移量为 {deliveryResult.Offset}");
                Console.ResetColor();
            }
            catch (ProduceException<Null, string> e)
            {
                // 5. 处理异常
                // -----------
                // 如果发送失败，会抛出 ProduceException 异常。
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"发送失败: {e.Error.Reason}");
                Console.ResetColor();
            }
            Task.Delay(TimeSpan.FromSeconds(10)).Wait();
        }

    }
}