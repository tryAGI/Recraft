#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransformImageWithMaskRequest : global::System.IEquatable<TransformImageWithMaskRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageRequest? TransformImageRequest { get; init; }
#else
        public global::Recraft.TransformImageRequest? TransformImageRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransformImageRequest))]
#endif
        public bool IsTransformImageRequest => TransformImageRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageWithMaskRequestVariant2? TransformImageWithMaskRequestVariant2 { get; init; }
#else
        public global::Recraft.TransformImageWithMaskRequestVariant2? TransformImageWithMaskRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransformImageWithMaskRequestVariant2))]
#endif
        public bool IsTransformImageWithMaskRequestVariant2 => TransformImageWithMaskRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageWithMaskRequest(global::Recraft.TransformImageRequest value) => new TransformImageWithMaskRequest((global::Recraft.TransformImageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequest?(TransformImageWithMaskRequest @this) => @this.TransformImageRequest;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskRequest(global::Recraft.TransformImageRequest? value)
        {
            TransformImageRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageWithMaskRequest(global::Recraft.TransformImageWithMaskRequestVariant2 value) => new TransformImageWithMaskRequest((global::Recraft.TransformImageWithMaskRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageWithMaskRequestVariant2?(TransformImageWithMaskRequest @this) => @this.TransformImageWithMaskRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskRequest(global::Recraft.TransformImageWithMaskRequestVariant2? value)
        {
            TransformImageWithMaskRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskRequest(
            global::Recraft.TransformImageRequest? transformImageRequest,
            global::Recraft.TransformImageWithMaskRequestVariant2? transformImageWithMaskRequestVariant2
            )
        {
            TransformImageRequest = transformImageRequest;
            TransformImageWithMaskRequestVariant2 = transformImageWithMaskRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TransformImageWithMaskRequestVariant2 as object ??
            TransformImageRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TransformImageRequest?.ToString() ??
            TransformImageWithMaskRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTransformImageRequest && IsTransformImageWithMaskRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageRequest?, TResult>? transformImageRequest = null,
            global::System.Func<global::Recraft.TransformImageWithMaskRequestVariant2?, TResult>? transformImageWithMaskRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransformImageRequest && transformImageRequest != null)
            {
                return transformImageRequest(TransformImageRequest!);
            }
            else if (IsTransformImageWithMaskRequestVariant2 && transformImageWithMaskRequestVariant2 != null)
            {
                return transformImageWithMaskRequestVariant2(TransformImageWithMaskRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageRequest?>? transformImageRequest = null,
            global::System.Action<global::Recraft.TransformImageWithMaskRequestVariant2?>? transformImageWithMaskRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransformImageRequest)
            {
                transformImageRequest?.Invoke(TransformImageRequest!);
            }
            else if (IsTransformImageWithMaskRequestVariant2)
            {
                transformImageWithMaskRequestVariant2?.Invoke(TransformImageWithMaskRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TransformImageRequest,
                typeof(global::Recraft.TransformImageRequest),
                TransformImageWithMaskRequestVariant2,
                typeof(global::Recraft.TransformImageWithMaskRequestVariant2),
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
        public bool Equals(TransformImageWithMaskRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequest?>.Default.Equals(TransformImageRequest, other.TransformImageRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageWithMaskRequestVariant2?>.Default.Equals(TransformImageWithMaskRequestVariant2, other.TransformImageWithMaskRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransformImageWithMaskRequest obj1, TransformImageWithMaskRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransformImageWithMaskRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransformImageWithMaskRequest obj1, TransformImageWithMaskRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransformImageWithMaskRequest o && Equals(o);
        }
    }
}
