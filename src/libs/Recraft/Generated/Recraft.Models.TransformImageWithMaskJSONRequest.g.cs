#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransformImageWithMaskJSONRequest : global::System.IEquatable<TransformImageWithMaskJSONRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageJSONRequest? TransformImageJSONRequest { get; init; }
#else
        public global::Recraft.TransformImageJSONRequest? TransformImageJSONRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransformImageJSONRequest))]
#endif
        public bool IsTransformImageJSONRequest => TransformImageJSONRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransformImageJSONRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageJSONRequest? value)
        {
            value = TransformImageJSONRequest;
            return IsTransformImageJSONRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageJSONRequest PickTransformImageJSONRequest() => IsTransformImageJSONRequest
            ? TransformImageJSONRequest!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransformImageJSONRequest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageWithMaskJSONRequestVariant2? TransformImageWithMaskJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.TransformImageWithMaskJSONRequestVariant2? TransformImageWithMaskJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransformImageWithMaskJSONRequestVariant2))]
#endif
        public bool IsTransformImageWithMaskJSONRequestVariant2 => TransformImageWithMaskJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransformImageWithMaskJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageWithMaskJSONRequestVariant2? value)
        {
            value = TransformImageWithMaskJSONRequestVariant2;
            return IsTransformImageWithMaskJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageWithMaskJSONRequestVariant2 PickTransformImageWithMaskJSONRequestVariant2() => IsTransformImageWithMaskJSONRequestVariant2
            ? TransformImageWithMaskJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransformImageWithMaskJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageWithMaskJSONRequest(global::Recraft.TransformImageJSONRequest value) => new TransformImageWithMaskJSONRequest((global::Recraft.TransformImageJSONRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageJSONRequest?(TransformImageWithMaskJSONRequest @this) => @this.TransformImageJSONRequest;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskJSONRequest(global::Recraft.TransformImageJSONRequest? value)
        {
            TransformImageJSONRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageWithMaskJSONRequest FromTransformImageJSONRequest(global::Recraft.TransformImageJSONRequest? value) => new TransformImageWithMaskJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformImageWithMaskJSONRequest(global::Recraft.TransformImageWithMaskJSONRequestVariant2 value) => new TransformImageWithMaskJSONRequest((global::Recraft.TransformImageWithMaskJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageWithMaskJSONRequestVariant2?(TransformImageWithMaskJSONRequest @this) => @this.TransformImageWithMaskJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskJSONRequest(global::Recraft.TransformImageWithMaskJSONRequestVariant2? value)
        {
            TransformImageWithMaskJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TransformImageWithMaskJSONRequest FromTransformImageWithMaskJSONRequestVariant2(global::Recraft.TransformImageWithMaskJSONRequestVariant2? value) => new TransformImageWithMaskJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public TransformImageWithMaskJSONRequest(
            global::Recraft.TransformImageJSONRequest? transformImageJSONRequest,
            global::Recraft.TransformImageWithMaskJSONRequestVariant2? transformImageWithMaskJSONRequestVariant2
            )
        {
            TransformImageJSONRequest = transformImageJSONRequest;
            TransformImageWithMaskJSONRequestVariant2 = transformImageWithMaskJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TransformImageWithMaskJSONRequestVariant2 as object ??
            TransformImageJSONRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TransformImageJSONRequest?.ToString() ??
            TransformImageWithMaskJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTransformImageJSONRequest && IsTransformImageWithMaskJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageJSONRequest?, TResult>? transformImageJSONRequest = null,
            global::System.Func<global::Recraft.TransformImageWithMaskJSONRequestVariant2, TResult>? transformImageWithMaskJSONRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransformImageJSONRequest && transformImageJSONRequest != null)
            {
                return transformImageJSONRequest(TransformImageJSONRequest!);
            }
            else if (IsTransformImageWithMaskJSONRequestVariant2 && transformImageWithMaskJSONRequestVariant2 != null)
            {
                return transformImageWithMaskJSONRequestVariant2(TransformImageWithMaskJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageJSONRequest?>? transformImageJSONRequest = null,

            global::System.Action<global::Recraft.TransformImageWithMaskJSONRequestVariant2>? transformImageWithMaskJSONRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransformImageJSONRequest)
            {
                transformImageJSONRequest?.Invoke(TransformImageJSONRequest!);
            }
            else if (IsTransformImageWithMaskJSONRequestVariant2)
            {
                transformImageWithMaskJSONRequestVariant2?.Invoke(TransformImageWithMaskJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageJSONRequest?>? transformImageJSONRequest = null,
            global::System.Action<global::Recraft.TransformImageWithMaskJSONRequestVariant2>? transformImageWithMaskJSONRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransformImageJSONRequest)
            {
                transformImageJSONRequest?.Invoke(TransformImageJSONRequest!);
            }
            else if (IsTransformImageWithMaskJSONRequestVariant2)
            {
                transformImageWithMaskJSONRequestVariant2?.Invoke(TransformImageWithMaskJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TransformImageJSONRequest,
                typeof(global::Recraft.TransformImageJSONRequest),
                TransformImageWithMaskJSONRequestVariant2,
                typeof(global::Recraft.TransformImageWithMaskJSONRequestVariant2),
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
        public bool Equals(TransformImageWithMaskJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageJSONRequest?>.Default.Equals(TransformImageJSONRequest, other.TransformImageJSONRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageWithMaskJSONRequestVariant2?>.Default.Equals(TransformImageWithMaskJSONRequestVariant2, other.TransformImageWithMaskJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransformImageWithMaskJSONRequest obj1, TransformImageWithMaskJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransformImageWithMaskJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransformImageWithMaskJSONRequest obj1, TransformImageWithMaskJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransformImageWithMaskJSONRequest o && Equals(o);
        }
    }
}
