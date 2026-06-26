#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageToImageJSONRequest : global::System.IEquatable<ImageToImageJSONRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageJSONRequest? Transform { get; init; }
#else
        public global::Recraft.TransformImageJSONRequest? Transform { get; }
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
            out global::Recraft.TransformImageJSONRequest? value)
        {
            value = Transform;
            return IsTransform;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageJSONRequest PickTransform() => IsTransform
            ? Transform!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transform' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ImageToImageJSONRequestVariant2? ImageToImageJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.ImageToImageJSONRequestVariant2? ImageToImageJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToImageJSONRequestVariant2))]
#endif
        public bool IsImageToImageJSONRequestVariant2 => ImageToImageJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageToImageJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.ImageToImageJSONRequestVariant2? value)
        {
            value = ImageToImageJSONRequestVariant2;
            return IsImageToImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.ImageToImageJSONRequestVariant2 PickImageToImageJSONRequestVariant2() => IsImageToImageJSONRequestVariant2
            ? ImageToImageJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageToImageJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToImageJSONRequest(global::Recraft.TransformImageJSONRequest value) => new ImageToImageJSONRequest((global::Recraft.TransformImageJSONRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageJSONRequest?(ImageToImageJSONRequest @this) => @this.Transform;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageJSONRequest(global::Recraft.TransformImageJSONRequest? value)
        {
            Transform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageToImageJSONRequest FromTransform(global::Recraft.TransformImageJSONRequest? value) => new ImageToImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToImageJSONRequest(global::Recraft.ImageToImageJSONRequestVariant2 value) => new ImageToImageJSONRequest((global::Recraft.ImageToImageJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ImageToImageJSONRequestVariant2?(ImageToImageJSONRequest @this) => @this.ImageToImageJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageJSONRequest(global::Recraft.ImageToImageJSONRequestVariant2? value)
        {
            ImageToImageJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageToImageJSONRequest FromImageToImageJSONRequestVariant2(global::Recraft.ImageToImageJSONRequestVariant2? value) => new ImageToImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageJSONRequest(
            global::Recraft.TransformImageJSONRequest? transform,
            global::Recraft.ImageToImageJSONRequestVariant2? imageToImageJSONRequestVariant2
            )
        {
            Transform = transform;
            ImageToImageJSONRequestVariant2 = imageToImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageToImageJSONRequestVariant2 as object ??
            Transform as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Transform?.ToString() ??
            ImageToImageJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTransform && IsImageToImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageJSONRequest?, TResult>? transform = null,
            global::System.Func<global::Recraft.ImageToImageJSONRequestVariant2, TResult>? imageToImageJSONRequestVariant2 = null,
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
            else if (IsImageToImageJSONRequestVariant2 && imageToImageJSONRequestVariant2 != null)
            {
                return imageToImageJSONRequestVariant2(ImageToImageJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageJSONRequest?>? transform = null,

            global::System.Action<global::Recraft.ImageToImageJSONRequestVariant2>? imageToImageJSONRequestVariant2 = null,
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
            else if (IsImageToImageJSONRequestVariant2)
            {
                imageToImageJSONRequestVariant2?.Invoke(ImageToImageJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageJSONRequest?>? transform = null,
            global::System.Action<global::Recraft.ImageToImageJSONRequestVariant2>? imageToImageJSONRequestVariant2 = null,
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
            else if (IsImageToImageJSONRequestVariant2)
            {
                imageToImageJSONRequestVariant2?.Invoke(ImageToImageJSONRequestVariant2!);
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
                typeof(global::Recraft.TransformImageJSONRequest),
                ImageToImageJSONRequestVariant2,
                typeof(global::Recraft.ImageToImageJSONRequestVariant2),
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
        public bool Equals(ImageToImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageJSONRequest?>.Default.Equals(Transform, other.Transform) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ImageToImageJSONRequestVariant2?>.Default.Equals(ImageToImageJSONRequestVariant2, other.ImageToImageJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageToImageJSONRequest obj1, ImageToImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageToImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageToImageJSONRequest obj1, ImageToImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageToImageJSONRequest o && Equals(o);
        }
    }
}
