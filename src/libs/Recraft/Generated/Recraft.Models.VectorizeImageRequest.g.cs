#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VectorizeImageRequest : global::System.IEquatable<VectorizeImageRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VectorizeImageRequestBase? Base { get; init; }
#else
        public global::Recraft.VectorizeImageRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.VectorizeImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VectorizeImageRequestBase PickBase() => IsBase
            ? Base!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VectorizeImageRequestVariant2? VectorizeImageRequestVariant2 { get; init; }
#else
        public global::Recraft.VectorizeImageRequestVariant2? VectorizeImageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorizeImageRequestVariant2))]
#endif
        public bool IsVectorizeImageRequestVariant2 => VectorizeImageRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorizeImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.VectorizeImageRequestVariant2? value)
        {
            value = VectorizeImageRequestVariant2;
            return IsVectorizeImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VectorizeImageRequestVariant2 PickVectorizeImageRequestVariant2() => IsVectorizeImageRequestVariant2
            ? VectorizeImageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorizeImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageRequest(global::Recraft.VectorizeImageRequestBase value) => new VectorizeImageRequest((global::Recraft.VectorizeImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VectorizeImageRequestBase?(VectorizeImageRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequest(global::Recraft.VectorizeImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorizeImageRequest FromBase(global::Recraft.VectorizeImageRequestBase? value) => new VectorizeImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageRequest(global::Recraft.VectorizeImageRequestVariant2 value) => new VectorizeImageRequest((global::Recraft.VectorizeImageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VectorizeImageRequestVariant2?(VectorizeImageRequest @this) => @this.VectorizeImageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequest(global::Recraft.VectorizeImageRequestVariant2? value)
        {
            VectorizeImageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorizeImageRequest FromVectorizeImageRequestVariant2(global::Recraft.VectorizeImageRequestVariant2? value) => new VectorizeImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequest(
            global::Recraft.VectorizeImageRequestBase? @base,
            global::Recraft.VectorizeImageRequestVariant2? vectorizeImageRequestVariant2
            )
        {
            Base = @base;
            VectorizeImageRequestVariant2 = vectorizeImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorizeImageRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            VectorizeImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsVectorizeImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.VectorizeImageRequestBase?, TResult>? @base = null,
            global::System.Func<global::Recraft.VectorizeImageRequestVariant2, TResult>? vectorizeImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsVectorizeImageRequestVariant2 && vectorizeImageRequestVariant2 != null)
            {
                return vectorizeImageRequestVariant2(VectorizeImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.VectorizeImageRequestBase?>? @base = null,

            global::System.Action<global::Recraft.VectorizeImageRequestVariant2>? vectorizeImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsVectorizeImageRequestVariant2)
            {
                vectorizeImageRequestVariant2?.Invoke(VectorizeImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.VectorizeImageRequestBase?>? @base = null,
            global::System.Action<global::Recraft.VectorizeImageRequestVariant2>? vectorizeImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsVectorizeImageRequestVariant2)
            {
                vectorizeImageRequestVariant2?.Invoke(VectorizeImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Recraft.VectorizeImageRequestBase),
                VectorizeImageRequestVariant2,
                typeof(global::Recraft.VectorizeImageRequestVariant2),
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
        public bool Equals(VectorizeImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VectorizeImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VectorizeImageRequestVariant2?>.Default.Equals(VectorizeImageRequestVariant2, other.VectorizeImageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorizeImageRequest obj1, VectorizeImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorizeImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorizeImageRequest obj1, VectorizeImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorizeImageRequest o && Equals(o);
        }
    }
}
