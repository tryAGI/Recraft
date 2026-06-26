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
        public global::Recraft.OutpaintImageRequestBase? Base { get; init; }
#else
        public global::Recraft.OutpaintImageRequestBase? Base { get; }
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
            out global::Recraft.OutpaintImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.OutpaintImageRequestBase PickBase() => IsBase
            ? Base!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

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
        public static implicit operator OutpaintImageRequest(global::Recraft.OutpaintImageRequestBase value) => new OutpaintImageRequest((global::Recraft.OutpaintImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.OutpaintImageRequestBase?(OutpaintImageRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageRequest(global::Recraft.OutpaintImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutpaintImageRequest FromBase(global::Recraft.OutpaintImageRequestBase? value) => new OutpaintImageRequest(value);

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
            global::Recraft.OutpaintImageRequestBase? @base,
            global::Recraft.OutpaintImageRequestVariant2? outpaintImageRequestVariant2
            )
        {
            Base = @base;
            OutpaintImageRequestVariant2 = outpaintImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutpaintImageRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            OutpaintImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsOutpaintImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.OutpaintImageRequestBase?, TResult>? @base = null,
            global::System.Func<global::Recraft.OutpaintImageRequestVariant2, TResult>? outpaintImageRequestVariant2 = null,
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
            global::System.Action<global::Recraft.OutpaintImageRequestBase?>? @base = null,

            global::System.Action<global::Recraft.OutpaintImageRequestVariant2>? outpaintImageRequestVariant2 = null,
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
            else if (IsOutpaintImageRequestVariant2)
            {
                outpaintImageRequestVariant2?.Invoke(OutpaintImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.OutpaintImageRequestBase?>? @base = null,
            global::System.Action<global::Recraft.OutpaintImageRequestVariant2>? outpaintImageRequestVariant2 = null,
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
                Base,
                typeof(global::Recraft.OutpaintImageRequestBase),
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
                global::System.Collections.Generic.EqualityComparer<global::Recraft.OutpaintImageRequestBase?>.Default.Equals(Base, other.Base) &&
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
