#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EraseRegionRequest : global::System.IEquatable<EraseRegionRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.EraseRegionRequestBase? Base { get; init; }
#else
        public global::Recraft.EraseRegionRequestBase? Base { get; }
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
            out global::Recraft.EraseRegionRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.EraseRegionRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.EraseRegionRequestVariant2? EraseRegionRequestVariant2 { get; init; }
#else
        public global::Recraft.EraseRegionRequestVariant2? EraseRegionRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EraseRegionRequestVariant2))]
#endif
        public bool IsEraseRegionRequestVariant2 => EraseRegionRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEraseRegionRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.EraseRegionRequestVariant2? value)
        {
            value = EraseRegionRequestVariant2;
            return IsEraseRegionRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.EraseRegionRequestVariant2 PickEraseRegionRequestVariant2() => IsEraseRegionRequestVariant2
            ? EraseRegionRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EraseRegionRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EraseRegionRequest(global::Recraft.EraseRegionRequestBase value) => new EraseRegionRequest((global::Recraft.EraseRegionRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.EraseRegionRequestBase?(EraseRegionRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public EraseRegionRequest(global::Recraft.EraseRegionRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EraseRegionRequest FromBase(global::Recraft.EraseRegionRequestBase? value) => new EraseRegionRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EraseRegionRequest(global::Recraft.EraseRegionRequestVariant2 value) => new EraseRegionRequest((global::Recraft.EraseRegionRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.EraseRegionRequestVariant2?(EraseRegionRequest @this) => @this.EraseRegionRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EraseRegionRequest(global::Recraft.EraseRegionRequestVariant2? value)
        {
            EraseRegionRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EraseRegionRequest FromEraseRegionRequestVariant2(global::Recraft.EraseRegionRequestVariant2? value) => new EraseRegionRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public EraseRegionRequest(
            global::Recraft.EraseRegionRequestBase? @base,
            global::Recraft.EraseRegionRequestVariant2? eraseRegionRequestVariant2
            )
        {
            Base = @base;
            EraseRegionRequestVariant2 = eraseRegionRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EraseRegionRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EraseRegionRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEraseRegionRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.EraseRegionRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.EraseRegionRequestVariant2, TResult>? eraseRegionRequestVariant2 = null,
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
            else if (IsEraseRegionRequestVariant2 && eraseRegionRequestVariant2 != null)
            {
                return eraseRegionRequestVariant2(EraseRegionRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.EraseRegionRequestBase>? @base = null,

            global::System.Action<global::Recraft.EraseRegionRequestVariant2>? eraseRegionRequestVariant2 = null,
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
            else if (IsEraseRegionRequestVariant2)
            {
                eraseRegionRequestVariant2?.Invoke(EraseRegionRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.EraseRegionRequestBase>? @base = null,
            global::System.Action<global::Recraft.EraseRegionRequestVariant2>? eraseRegionRequestVariant2 = null,
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
            else if (IsEraseRegionRequestVariant2)
            {
                eraseRegionRequestVariant2?.Invoke(EraseRegionRequestVariant2!);
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
                typeof(global::Recraft.EraseRegionRequestBase),
                EraseRegionRequestVariant2,
                typeof(global::Recraft.EraseRegionRequestVariant2),
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
        public bool Equals(EraseRegionRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EraseRegionRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EraseRegionRequestVariant2?>.Default.Equals(EraseRegionRequestVariant2, other.EraseRegionRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EraseRegionRequest obj1, EraseRegionRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EraseRegionRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EraseRegionRequest obj1, EraseRegionRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EraseRegionRequest o && Equals(o);
        }
    }
}
