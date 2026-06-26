#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VectorizeImageJSONRequest : global::System.IEquatable<VectorizeImageJSONRequest>
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
        public global::Recraft.VectorizeImageJSONRequestVariant2? VectorizeImageJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.VectorizeImageJSONRequestVariant2? VectorizeImageJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorizeImageJSONRequestVariant2))]
#endif
        public bool IsVectorizeImageJSONRequestVariant2 => VectorizeImageJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorizeImageJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.VectorizeImageJSONRequestVariant2? value)
        {
            value = VectorizeImageJSONRequestVariant2;
            return IsVectorizeImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VectorizeImageJSONRequestVariant2 PickVectorizeImageJSONRequestVariant2() => IsVectorizeImageJSONRequestVariant2
            ? VectorizeImageJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorizeImageJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageJSONRequest(global::Recraft.VectorizeImageRequestBase value) => new VectorizeImageJSONRequest((global::Recraft.VectorizeImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VectorizeImageRequestBase?(VectorizeImageJSONRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageJSONRequest(global::Recraft.VectorizeImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorizeImageJSONRequest FromBase(global::Recraft.VectorizeImageRequestBase? value) => new VectorizeImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageJSONRequest(global::Recraft.VectorizeImageJSONRequestVariant2 value) => new VectorizeImageJSONRequest((global::Recraft.VectorizeImageJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VectorizeImageJSONRequestVariant2?(VectorizeImageJSONRequest @this) => @this.VectorizeImageJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageJSONRequest(global::Recraft.VectorizeImageJSONRequestVariant2? value)
        {
            VectorizeImageJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorizeImageJSONRequest FromVectorizeImageJSONRequestVariant2(global::Recraft.VectorizeImageJSONRequestVariant2? value) => new VectorizeImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageJSONRequest(
            global::Recraft.VectorizeImageRequestBase? @base,
            global::Recraft.VectorizeImageJSONRequestVariant2? vectorizeImageJSONRequestVariant2
            )
        {
            Base = @base;
            VectorizeImageJSONRequestVariant2 = vectorizeImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorizeImageJSONRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            VectorizeImageJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsVectorizeImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.VectorizeImageRequestBase?, TResult>? @base = null,
            global::System.Func<global::Recraft.VectorizeImageJSONRequestVariant2, TResult>? vectorizeImageJSONRequestVariant2 = null,
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
            else if (IsVectorizeImageJSONRequestVariant2 && vectorizeImageJSONRequestVariant2 != null)
            {
                return vectorizeImageJSONRequestVariant2(VectorizeImageJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.VectorizeImageRequestBase?>? @base = null,

            global::System.Action<global::Recraft.VectorizeImageJSONRequestVariant2>? vectorizeImageJSONRequestVariant2 = null,
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
            else if (IsVectorizeImageJSONRequestVariant2)
            {
                vectorizeImageJSONRequestVariant2?.Invoke(VectorizeImageJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.VectorizeImageRequestBase?>? @base = null,
            global::System.Action<global::Recraft.VectorizeImageJSONRequestVariant2>? vectorizeImageJSONRequestVariant2 = null,
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
            else if (IsVectorizeImageJSONRequestVariant2)
            {
                vectorizeImageJSONRequestVariant2?.Invoke(VectorizeImageJSONRequestVariant2!);
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
                VectorizeImageJSONRequestVariant2,
                typeof(global::Recraft.VectorizeImageJSONRequestVariant2),
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
        public bool Equals(VectorizeImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VectorizeImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VectorizeImageJSONRequestVariant2?>.Default.Equals(VectorizeImageJSONRequestVariant2, other.VectorizeImageJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorizeImageJSONRequest obj1, VectorizeImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorizeImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorizeImageJSONRequest obj1, VectorizeImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorizeImageJSONRequest o && Equals(o);
        }
    }
}
