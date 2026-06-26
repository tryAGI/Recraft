#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EraseRegionJSONRequest : global::System.IEquatable<EraseRegionJSONRequest>
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
        public global::Recraft.EraseRegionJSONRequestVariant2? EraseRegionJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.EraseRegionJSONRequestVariant2? EraseRegionJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EraseRegionJSONRequestVariant2))]
#endif
        public bool IsEraseRegionJSONRequestVariant2 => EraseRegionJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEraseRegionJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.EraseRegionJSONRequestVariant2? value)
        {
            value = EraseRegionJSONRequestVariant2;
            return IsEraseRegionJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.EraseRegionJSONRequestVariant2 PickEraseRegionJSONRequestVariant2() => IsEraseRegionJSONRequestVariant2
            ? EraseRegionJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EraseRegionJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EraseRegionJSONRequest(global::Recraft.EraseRegionRequestBase value) => new EraseRegionJSONRequest((global::Recraft.EraseRegionRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.EraseRegionRequestBase?(EraseRegionJSONRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public EraseRegionJSONRequest(global::Recraft.EraseRegionRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EraseRegionJSONRequest FromBase(global::Recraft.EraseRegionRequestBase? value) => new EraseRegionJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EraseRegionJSONRequest(global::Recraft.EraseRegionJSONRequestVariant2 value) => new EraseRegionJSONRequest((global::Recraft.EraseRegionJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.EraseRegionJSONRequestVariant2?(EraseRegionJSONRequest @this) => @this.EraseRegionJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EraseRegionJSONRequest(global::Recraft.EraseRegionJSONRequestVariant2? value)
        {
            EraseRegionJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EraseRegionJSONRequest FromEraseRegionJSONRequestVariant2(global::Recraft.EraseRegionJSONRequestVariant2? value) => new EraseRegionJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public EraseRegionJSONRequest(
            global::Recraft.EraseRegionRequestBase? @base,
            global::Recraft.EraseRegionJSONRequestVariant2? eraseRegionJSONRequestVariant2
            )
        {
            Base = @base;
            EraseRegionJSONRequestVariant2 = eraseRegionJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EraseRegionJSONRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EraseRegionJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEraseRegionJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.EraseRegionRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.EraseRegionJSONRequestVariant2, TResult>? eraseRegionJSONRequestVariant2 = null,
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
            else if (IsEraseRegionJSONRequestVariant2 && eraseRegionJSONRequestVariant2 != null)
            {
                return eraseRegionJSONRequestVariant2(EraseRegionJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.EraseRegionRequestBase>? @base = null,

            global::System.Action<global::Recraft.EraseRegionJSONRequestVariant2>? eraseRegionJSONRequestVariant2 = null,
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
            else if (IsEraseRegionJSONRequestVariant2)
            {
                eraseRegionJSONRequestVariant2?.Invoke(EraseRegionJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.EraseRegionRequestBase>? @base = null,
            global::System.Action<global::Recraft.EraseRegionJSONRequestVariant2>? eraseRegionJSONRequestVariant2 = null,
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
            else if (IsEraseRegionJSONRequestVariant2)
            {
                eraseRegionJSONRequestVariant2?.Invoke(EraseRegionJSONRequestVariant2!);
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
                EraseRegionJSONRequestVariant2,
                typeof(global::Recraft.EraseRegionJSONRequestVariant2),
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
        public bool Equals(EraseRegionJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EraseRegionRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.EraseRegionJSONRequestVariant2?>.Default.Equals(EraseRegionJSONRequestVariant2, other.EraseRegionJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EraseRegionJSONRequest obj1, EraseRegionJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EraseRegionJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EraseRegionJSONRequest obj1, EraseRegionJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EraseRegionJSONRequest o && Equals(o);
        }
    }
}
