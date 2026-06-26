#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VariateImageJSONRequest : global::System.IEquatable<VariateImageJSONRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VariateImageRequestBase? Base { get; init; }
#else
        public global::Recraft.VariateImageRequestBase? Base { get; }
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
            out global::Recraft.VariateImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VariateImageRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VariateImageJSONRequestVariant2? VariateImageJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.VariateImageJSONRequestVariant2? VariateImageJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VariateImageJSONRequestVariant2))]
#endif
        public bool IsVariateImageJSONRequestVariant2 => VariateImageJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVariateImageJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.VariateImageJSONRequestVariant2? value)
        {
            value = VariateImageJSONRequestVariant2;
            return IsVariateImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VariateImageJSONRequestVariant2 PickVariateImageJSONRequestVariant2() => IsVariateImageJSONRequestVariant2
            ? VariateImageJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VariateImageJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VariateImageJSONRequest(global::Recraft.VariateImageRequestBase value) => new VariateImageJSONRequest((global::Recraft.VariateImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VariateImageRequestBase?(VariateImageJSONRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public VariateImageJSONRequest(global::Recraft.VariateImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VariateImageJSONRequest FromBase(global::Recraft.VariateImageRequestBase? value) => new VariateImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VariateImageJSONRequest(global::Recraft.VariateImageJSONRequestVariant2 value) => new VariateImageJSONRequest((global::Recraft.VariateImageJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VariateImageJSONRequestVariant2?(VariateImageJSONRequest @this) => @this.VariateImageJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VariateImageJSONRequest(global::Recraft.VariateImageJSONRequestVariant2? value)
        {
            VariateImageJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VariateImageJSONRequest FromVariateImageJSONRequestVariant2(global::Recraft.VariateImageJSONRequestVariant2? value) => new VariateImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public VariateImageJSONRequest(
            global::Recraft.VariateImageRequestBase? @base,
            global::Recraft.VariateImageJSONRequestVariant2? variateImageJSONRequestVariant2
            )
        {
            Base = @base;
            VariateImageJSONRequestVariant2 = variateImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VariateImageJSONRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            VariateImageJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsVariateImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.VariateImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.VariateImageJSONRequestVariant2, TResult>? variateImageJSONRequestVariant2 = null,
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
            else if (IsVariateImageJSONRequestVariant2 && variateImageJSONRequestVariant2 != null)
            {
                return variateImageJSONRequestVariant2(VariateImageJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.VariateImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.VariateImageJSONRequestVariant2>? variateImageJSONRequestVariant2 = null,
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
            else if (IsVariateImageJSONRequestVariant2)
            {
                variateImageJSONRequestVariant2?.Invoke(VariateImageJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.VariateImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.VariateImageJSONRequestVariant2>? variateImageJSONRequestVariant2 = null,
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
            else if (IsVariateImageJSONRequestVariant2)
            {
                variateImageJSONRequestVariant2?.Invoke(VariateImageJSONRequestVariant2!);
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
                typeof(global::Recraft.VariateImageRequestBase),
                VariateImageJSONRequestVariant2,
                typeof(global::Recraft.VariateImageJSONRequestVariant2),
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
        public bool Equals(VariateImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VariateImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VariateImageJSONRequestVariant2?>.Default.Equals(VariateImageJSONRequestVariant2, other.VariateImageJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VariateImageJSONRequest obj1, VariateImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VariateImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VariateImageJSONRequest obj1, VariateImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VariateImageJSONRequest o && Equals(o);
        }
    }
}
