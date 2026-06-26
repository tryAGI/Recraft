#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ProcessImageRequest : global::System.IEquatable<ProcessImageRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ProcessImageRequestBase? Base { get; init; }
#else
        public global::Recraft.ProcessImageRequestBase? Base { get; }
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
            out global::Recraft.ProcessImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.ProcessImageRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ProcessImageRequestVariant2? ProcessImageRequestVariant2 { get; init; }
#else
        public global::Recraft.ProcessImageRequestVariant2? ProcessImageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProcessImageRequestVariant2))]
#endif
        public bool IsProcessImageRequestVariant2 => ProcessImageRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProcessImageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.ProcessImageRequestVariant2? value)
        {
            value = ProcessImageRequestVariant2;
            return IsProcessImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.ProcessImageRequestVariant2 PickProcessImageRequestVariant2() => IsProcessImageRequestVariant2
            ? ProcessImageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProcessImageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProcessImageRequest(global::Recraft.ProcessImageRequestBase value) => new ProcessImageRequest((global::Recraft.ProcessImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ProcessImageRequestBase?(ProcessImageRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ProcessImageRequest(global::Recraft.ProcessImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ProcessImageRequest FromBase(global::Recraft.ProcessImageRequestBase? value) => new ProcessImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProcessImageRequest(global::Recraft.ProcessImageRequestVariant2 value) => new ProcessImageRequest((global::Recraft.ProcessImageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ProcessImageRequestVariant2?(ProcessImageRequest @this) => @this.ProcessImageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ProcessImageRequest(global::Recraft.ProcessImageRequestVariant2? value)
        {
            ProcessImageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ProcessImageRequest FromProcessImageRequestVariant2(global::Recraft.ProcessImageRequestVariant2? value) => new ProcessImageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ProcessImageRequest(
            global::Recraft.ProcessImageRequestBase? @base,
            global::Recraft.ProcessImageRequestVariant2? processImageRequestVariant2
            )
        {
            Base = @base;
            ProcessImageRequestVariant2 = processImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ProcessImageRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ProcessImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsProcessImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.ProcessImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.ProcessImageRequestVariant2, TResult>? processImageRequestVariant2 = null,
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
            else if (IsProcessImageRequestVariant2 && processImageRequestVariant2 != null)
            {
                return processImageRequestVariant2(ProcessImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.ProcessImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.ProcessImageRequestVariant2>? processImageRequestVariant2 = null,
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
            else if (IsProcessImageRequestVariant2)
            {
                processImageRequestVariant2?.Invoke(ProcessImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.ProcessImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.ProcessImageRequestVariant2>? processImageRequestVariant2 = null,
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
            else if (IsProcessImageRequestVariant2)
            {
                processImageRequestVariant2?.Invoke(ProcessImageRequestVariant2!);
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
                typeof(global::Recraft.ProcessImageRequestBase),
                ProcessImageRequestVariant2,
                typeof(global::Recraft.ProcessImageRequestVariant2),
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
        public bool Equals(ProcessImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ProcessImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ProcessImageRequestVariant2?>.Default.Equals(ProcessImageRequestVariant2, other.ProcessImageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProcessImageRequest obj1, ProcessImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProcessImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProcessImageRequest obj1, ProcessImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProcessImageRequest o && Equals(o);
        }
    }
}
