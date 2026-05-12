#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutpaintImageRequest : global::System.IEquatable<OutpaintImageRequest>
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
            ? Transform!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transform' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.OutpaintImageRequestVariant2? OutpaintImageRequestVariant2 { get; init; }
#else
        public global::Recraft.OutpaintImageRequestVariant2? OutpaintImageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutpaintImageRequestVariant2))]
#endif
        public bool IsOutpaintImageRequestVariant2 => OutpaintImageRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutpaintImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.OutpaintImageRequestVariant2? value)
        {
            value = OutpaintImageRequestVariant2;
            return IsOutpaintImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.OutpaintImageRequestVariant2 PickOutpaintImageRequestVariant2() => IsOutpaintImageRequestVariant2
            ? OutpaintImageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutpaintImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutpaintImageRequest(global::Recraft.TransformImageRequest value) => new OutpaintImageRequest((global::Recraft.TransformImageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequest?(OutpaintImageRequest @this) => @this.Transform;

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageRequest(global::Recraft.TransformImageRequest? value)
        {
            Transform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutpaintImageRequest FromTransform(global::Recraft.TransformImageRequest? value) => new OutpaintImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutpaintImageRequest(global::Recraft.OutpaintImageRequestVariant2 value) => new OutpaintImageRequest((global::Recraft.OutpaintImageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.OutpaintImageRequestVariant2?(OutpaintImageRequest @this) => @this.OutpaintImageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageRequest(global::Recraft.OutpaintImageRequestVariant2? value)
        {
            OutpaintImageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutpaintImageRequest FromOutpaintImageRequestVariant2(global::Recraft.OutpaintImageRequestVariant2? value) => new OutpaintImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageRequest(
            global::Recraft.TransformImageRequest? transform,
            global::Recraft.OutpaintImageRequestVariant2? outpaintImageRequestVariant2
            )
        {
            Transform = transform;
            OutpaintImageRequestVariant2 = outpaintImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutpaintImageRequestVariant2 as object ??
            Transform as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Transform?.ToString() ??
            OutpaintImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTransform && IsOutpaintImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageRequest, TResult>? transform = null,
            global::System.Func<global::Recraft.OutpaintImageRequestVariant2, TResult>? outpaintImageRequestVariant2 = null,
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
            else if (IsOutpaintImageRequestVariant2 && outpaintImageRequestVariant2 != null)
            {
                return outpaintImageRequestVariant2(OutpaintImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageRequest>? transform = null,

            global::System.Action<global::Recraft.OutpaintImageRequestVariant2>? outpaintImageRequestVariant2 = null,
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
            else if (IsOutpaintImageRequestVariant2)
            {
                outpaintImageRequestVariant2?.Invoke(OutpaintImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageRequest>? transform = null,
            global::System.Action<global::Recraft.OutpaintImageRequestVariant2>? outpaintImageRequestVariant2 = null,
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
            else if (IsOutpaintImageRequestVariant2)
            {
                outpaintImageRequestVariant2?.Invoke(OutpaintImageRequestVariant2!);
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
                OutpaintImageRequestVariant2,
                typeof(global::Recraft.OutpaintImageRequestVariant2),
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
        public bool Equals(OutpaintImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequest?>.Default.Equals(Transform, other.Transform) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.OutpaintImageRequestVariant2?>.Default.Equals(OutpaintImageRequestVariant2, other.OutpaintImageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutpaintImageRequest obj1, OutpaintImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutpaintImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutpaintImageRequest obj1, OutpaintImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutpaintImageRequest o && Equals(o);
        }
    }
}
