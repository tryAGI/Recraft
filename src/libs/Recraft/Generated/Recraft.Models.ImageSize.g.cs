
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageSize
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1365x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1365,
        /// <summary>
        /// 
        /// </summary>
        x1536x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1536,
        /// <summary>
        /// 
        /// </summary>
        x1820x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1820,
        /// <summary>
        /// 
        /// </summary>
        x1024x2048,
        /// <summary>
        /// 
        /// </summary>
        x2048x1024,
        /// <summary>
        /// 
        /// </summary>
        x1434x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1434,
        /// <summary>
        /// 
        /// </summary>
        x1024x1280,
        /// <summary>
        /// 
        /// </summary>
        x1280x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1707,
        /// <summary>
        /// 
        /// </summary>
        x1707x1024,
        /// <summary>
        /// 
        /// </summary>
        x1216x896,
        /// <summary>
        /// 
        /// </summary>
        x896x1216,
        /// <summary>
        /// 
        /// </summary>
        x1280x832,
        /// <summary>
        /// 
        /// </summary>
        x832x1280,
        /// <summary>
        /// 
        /// </summary>
        x1152x896,
        /// <summary>
        /// 
        /// </summary>
        x896x1152,
        /// <summary>
        /// 
        /// </summary>
        x1280x896,
        /// <summary>
        /// 
        /// </summary>
        x896x1280,
        /// <summary>
        /// 
        /// </summary>
        x832x1344,
        /// <summary>
        /// 
        /// </summary>
        x768x1344,
        /// <summary>
        /// 
        /// </summary>
        x1344x768,
        /// <summary>
        /// 
        /// </summary>
        x768x1536,
        /// <summary>
        /// 
        /// </summary>
        x1536x768,
        /// <summary>
        /// 
        /// </summary>
        x2048x2048,
        /// <summary>
        /// 
        /// </summary>
        x2432x1792,
        /// <summary>
        /// 
        /// </summary>
        x1792x2432,
        /// <summary>
        /// 
        /// </summary>
        x2560x1664,
        /// <summary>
        /// 
        /// </summary>
        x1664x2560,
        /// <summary>
        /// 
        /// </summary>
        x2304x1792,
        /// <summary>
        /// 
        /// </summary>
        x1792x2304,
        /// <summary>
        /// 
        /// </summary>
        x2560x1792,
        /// <summary>
        /// 
        /// </summary>
        x1792x2560,
        /// <summary>
        /// 
        /// </summary>
        x1664x2688,
        /// <summary>
        /// 
        /// </summary>
        x1536x2688,
        /// <summary>
        /// 
        /// </summary>
        x2688x1536,
        /// <summary>
        /// 
        /// </summary>
        x1536x3072,
        /// <summary>
        /// 
        /// </summary>
        x3072x1536,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x2_1,
        /// <summary>
        /// 
        /// </summary>
        x1_2,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x5_4,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x6_10,
        /// <summary>
        /// 
        /// </summary>
        x14_10,
        /// <summary>
        /// 
        /// </summary>
        x10_14,
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSize value)
        {
            return value switch
            {
                ImageSize.x1024x1024 => "1024x1024",
                ImageSize.x1365x1024 => "1365x1024",
                ImageSize.x1024x1365 => "1024x1365",
                ImageSize.x1536x1024 => "1536x1024",
                ImageSize.x1024x1536 => "1024x1536",
                ImageSize.x1820x1024 => "1820x1024",
                ImageSize.x1024x1820 => "1024x1820",
                ImageSize.x1024x2048 => "1024x2048",
                ImageSize.x2048x1024 => "2048x1024",
                ImageSize.x1434x1024 => "1434x1024",
                ImageSize.x1024x1434 => "1024x1434",
                ImageSize.x1024x1280 => "1024x1280",
                ImageSize.x1280x1024 => "1280x1024",
                ImageSize.x1024x1707 => "1024x1707",
                ImageSize.x1707x1024 => "1707x1024",
                ImageSize.x1216x896 => "1216x896",
                ImageSize.x896x1216 => "896x1216",
                ImageSize.x1280x832 => "1280x832",
                ImageSize.x832x1280 => "832x1280",
                ImageSize.x1152x896 => "1152x896",
                ImageSize.x896x1152 => "896x1152",
                ImageSize.x1280x896 => "1280x896",
                ImageSize.x896x1280 => "896x1280",
                ImageSize.x832x1344 => "832x1344",
                ImageSize.x768x1344 => "768x1344",
                ImageSize.x1344x768 => "1344x768",
                ImageSize.x768x1536 => "768x1536",
                ImageSize.x1536x768 => "1536x768",
                ImageSize.x2048x2048 => "2048x2048",
                ImageSize.x2432x1792 => "2432x1792",
                ImageSize.x1792x2432 => "1792x2432",
                ImageSize.x2560x1664 => "2560x1664",
                ImageSize.x1664x2560 => "1664x2560",
                ImageSize.x2304x1792 => "2304x1792",
                ImageSize.x1792x2304 => "1792x2304",
                ImageSize.x2560x1792 => "2560x1792",
                ImageSize.x1792x2560 => "1792x2560",
                ImageSize.x1664x2688 => "1664x2688",
                ImageSize.x1536x2688 => "1536x2688",
                ImageSize.x2688x1536 => "2688x1536",
                ImageSize.x1536x3072 => "1536x3072",
                ImageSize.x3072x1536 => "3072x1536",
                ImageSize.x1_1 => "1:1",
                ImageSize.x2_1 => "2:1",
                ImageSize.x1_2 => "1:2",
                ImageSize.x3_2 => "3:2",
                ImageSize.x2_3 => "2:3",
                ImageSize.x4_3 => "4:3",
                ImageSize.x3_4 => "3:4",
                ImageSize.x5_4 => "5:4",
                ImageSize.x4_5 => "4:5",
                ImageSize.x6_10 => "6:10",
                ImageSize.x14_10 => "14:10",
                ImageSize.x10_14 => "10:14",
                ImageSize.x16_9 => "16:9",
                ImageSize.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageSize.x1024x1024,
                "1365x1024" => ImageSize.x1365x1024,
                "1024x1365" => ImageSize.x1024x1365,
                "1536x1024" => ImageSize.x1536x1024,
                "1024x1536" => ImageSize.x1024x1536,
                "1820x1024" => ImageSize.x1820x1024,
                "1024x1820" => ImageSize.x1024x1820,
                "1024x2048" => ImageSize.x1024x2048,
                "2048x1024" => ImageSize.x2048x1024,
                "1434x1024" => ImageSize.x1434x1024,
                "1024x1434" => ImageSize.x1024x1434,
                "1024x1280" => ImageSize.x1024x1280,
                "1280x1024" => ImageSize.x1280x1024,
                "1024x1707" => ImageSize.x1024x1707,
                "1707x1024" => ImageSize.x1707x1024,
                "1216x896" => ImageSize.x1216x896,
                "896x1216" => ImageSize.x896x1216,
                "1280x832" => ImageSize.x1280x832,
                "832x1280" => ImageSize.x832x1280,
                "1152x896" => ImageSize.x1152x896,
                "896x1152" => ImageSize.x896x1152,
                "1280x896" => ImageSize.x1280x896,
                "896x1280" => ImageSize.x896x1280,
                "832x1344" => ImageSize.x832x1344,
                "768x1344" => ImageSize.x768x1344,
                "1344x768" => ImageSize.x1344x768,
                "768x1536" => ImageSize.x768x1536,
                "1536x768" => ImageSize.x1536x768,
                "2048x2048" => ImageSize.x2048x2048,
                "2432x1792" => ImageSize.x2432x1792,
                "1792x2432" => ImageSize.x1792x2432,
                "2560x1664" => ImageSize.x2560x1664,
                "1664x2560" => ImageSize.x1664x2560,
                "2304x1792" => ImageSize.x2304x1792,
                "1792x2304" => ImageSize.x1792x2304,
                "2560x1792" => ImageSize.x2560x1792,
                "1792x2560" => ImageSize.x1792x2560,
                "1664x2688" => ImageSize.x1664x2688,
                "1536x2688" => ImageSize.x1536x2688,
                "2688x1536" => ImageSize.x2688x1536,
                "1536x3072" => ImageSize.x1536x3072,
                "3072x1536" => ImageSize.x3072x1536,
                "1:1" => ImageSize.x1_1,
                "2:1" => ImageSize.x2_1,
                "1:2" => ImageSize.x1_2,
                "3:2" => ImageSize.x3_2,
                "2:3" => ImageSize.x2_3,
                "4:3" => ImageSize.x4_3,
                "3:4" => ImageSize.x3_4,
                "5:4" => ImageSize.x5_4,
                "4:5" => ImageSize.x4_5,
                "6:10" => ImageSize.x6_10,
                "14:10" => ImageSize.x14_10,
                "10:14" => ImageSize.x10_14,
                "16:9" => ImageSize.x16_9,
                "9:16" => ImageSize.x9_16,
                _ => null,
            };
        }
    }
}