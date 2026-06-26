#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageToImageRequest : global::System.IEquatable<ImageToImageRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageRequest? Transform { get; init; }
#else
        public global::Recraft.TransformImageRequest? Transform { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transform))]
#endif
        public bool IsTransform => Transform != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransform(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageRequest? value)
        {
            value = Transform;
            return IsTransform;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageRequest PickTransform() => IsTransform
            ? Transform!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transform' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ImageToImageRequestVariant2? ImageToImageRequestVariant2 { get; init; }
#else
        public global::Recraft.ImageToImageRequestVariant2? ImageToImageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToImageRequestVariant2))]
#endif
        public bool IsImageToImageRequestVariant2 => ImageToImageRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageToImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.ImageToImageRequestVariant2? value)
        {
            value = ImageToImageRequestVariant2;
            return IsImageToImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.ImageToImageRequestVariant2 PickImageToImageRequestVariant2() => IsImageToImageRequestVariant2
            ? ImageToImageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageToImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToImageRequest(global::Recraft.TransformImageRequest value) => new ImageToImageRequest((global::Recraft.TransformImageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequest?(ImageToImageRequest @this) => @this.Transform;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageRequest(global::Recraft.TransformImageRequest? value)
        {
            Transform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageToImageRequest FromTransform(global::Recraft.TransformImageRequest? value) => new ImageToImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToImageRequest(global::Recraft.ImageToImageRequestVariant2 value) => new ImageToImageRequest((global::Recraft.ImageToImageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ImageToImageRequestVariant2?(ImageToImageRequest @this) => @this.ImageToImageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageRequest(global::Recraft.ImageToImageRequestVariant2? value)
        {
            ImageToImageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageToImageRequest FromImageToImageRequestVariant2(global::Recraft.ImageToImageRequestVariant2? value) => new ImageToImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageRequest(
            global::Recraft.TransformImageRequest? transform,
            global::Recraft.ImageToImageRequestVariant2? imageToImageRequestVariant2
            )
        {
            Transform = transform;
            ImageToImageRequestVariant2 = imageToImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageToImageRequestVariant2 as object ??
            Transform as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Transform?.ToString() ??
            ImageToImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTransform && IsImageToImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageRequest?, TResult>? transform = null,
            global::System.Func<global::Recraft.ImageToImageRequestVariant2, TResult>? imageToImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransform && transform != null)
            {
                return transform(Transform!);
            }
            else if (IsImageToImageRequestVariant2 && imageToImageRequestVariant2 != null)
            {
                return imageToImageRequestVariant2(ImageToImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageRequest?>? transform = null,

            global::System.Action<global::Recraft.ImageToImageRequestVariant2>? imageToImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransform)
            {
                transform?.Invoke(Transform!);
            }
            else if (IsImageToImageRequestVariant2)
            {
                imageToImageRequestVariant2?.Invoke(ImageToImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageRequest?>? transform = null,
            global::System.Action<global::Recraft.ImageToImageRequestVariant2>? imageToImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransform)
            {
                transform?.Invoke(Transform!);
            }
            else if (IsImageToImageRequestVariant2)
            {
                imageToImageRequestVariant2?.Invoke(ImageToImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Transform,
                typeof(global::Recraft.TransformImageRequest),
                ImageToImageRequestVariant2,
                typeof(global::Recraft.ImageToImageRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ImageToImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequest?>.Default.Equals(Transform, other.Transform) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ImageToImageRequestVariant2?>.Default.Equals(ImageToImageRequestVariant2, other.ImageToImageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageToImageRequest obj1, ImageToImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageToImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageToImageRequest obj1, ImageToImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageToImageRequest o && Equals(o);
        }
    }
}
